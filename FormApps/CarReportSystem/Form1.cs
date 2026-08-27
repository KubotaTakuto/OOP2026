using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理専用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //設定クラスのオブジェクトを生成
        //Settings settings = Settings.Instance;


        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }

        private void Form1_Load(object sender, EventArgs e) {
            //設定ファイルを読み込み背景色を設定する（逆シリアル化）

            //背景色を設定
            try {
                Settings.Instance.Load();
                BackColor = Color.FromArgb(Settings.Instance.MainFormBackColor);
            }
            catch (Exception ex) {
                tsslbMessage.Text = "設定読み込みエラー";
                MessageBox.Show(ex.Message);//←より具体的なエラーを出力
            }
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {

            tsslbMessage.Text = string.Empty;

            //記録者と車名が未入力だった場合は追加しない
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                if (string.IsNullOrWhiteSpace(cbAuthor.Text) || string.IsNullOrWhiteSpace(cbCarName.Text))
                    tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text.Trim(),
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);
            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
            dgvRecords.CurrentRow.Selected = false; //セルの選択を解除する
            InputItemsAllClear();
        }

        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                return MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return MakerGroup.スバル;
            }
            if (rbImport.Checked) {
                return MakerGroup.輸入車;
            }
            return MakerGroup.その他;
        }

        private void btOpenPicture_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            InputItemsAllClear();
        }

        private void InputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;

            dgvRecords.ClearSelection();    //セルの選択解除
        }

        private void SetRadioButtonMaler(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //記録者の入力履歴をコンボボックスへ登録(重複なし)
        private void SetCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //車名の入力履歴をコンボボックスへ登録(重複なし)
        private void SetCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDeleteRecord_Click(object sender, EventArgs e) {
            //選択されているインデックスを取得
            //削除したいインデックスを指定してリストから削除
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "削除するレポートを選択してください";
                return;
            }
            listCarReports.Remove(carReport);            
        }

        private void ImputItemsUpdate() {
            if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected) {
                InputItemsAllClear();
            }
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {
            if (dgvRecords.SelectedRows.Count == 0) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                if (string.IsNullOrWhiteSpace(cbAuthor.Text) || string.IsNullOrWhiteSpace(cbCarName.Text))
                    tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "削除するレポートを選択してください";
                return;
            }

            //カーレポート管理用リストの該当する要素を書き換える
            listCarReports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value.Date;
            listCarReports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text.Trim();
            listCarReports[dgvRecords.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text.Trim();
            listCarReports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;

            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.Refresh();//データグリッドビューの更新
            tsslbMessage.Text = "レポートを修正しました。";
        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e) {
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport
                || !dgvRecords.CurrentRow.Selected) return;

            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaler(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;

            ImputItemsUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                //変更された色の情報を保存
                Settings.Instance.MainFormBackColor = cdColor.Color.ToArgb();
            }
        }
        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理(シリアル化)

            Settings.Instance.Save();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            reportOpenFile();
        }
        //ファイルセーブ処理
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //ファイルオープン処理
        private void reportOpenFile() {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(ofdPicFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecords.DataSource = listCarReports;
                    }
                    //コンボボックスの履歴をすべて消す
                    cbAuthor.Items.Clear();
                    cbCarName.Items.Clear();
                    //コンボボックスの履歴を再登録
                    foreach (var report in listCarReports) {
                        SetCbAuthor(report.Author);
                        SetCbCarName(report.CarName);
                    }


                    //if (cbAuthor.Items != null) {
                    //    cbAuthor.Items.Clear();
                    //    foreach (var item in listCarReports) {
                    //        cbAuthor.Items.Add(item);
                    //    }
                    //}
                    //if (cbCarName != null) {
                    //    cbCarName.Items.Clear();
                    //    foreach (var item in listCarReports) {
                    //        cbCarName.Items.Add(item);
                    //    }
                    //}
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル読み出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
