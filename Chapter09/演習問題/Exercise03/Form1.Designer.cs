namespace Exercise03 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            btStart = new Button();
            btStop = new Button();
            lbTimeDisp = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tbReset = new Button();
            ラップボックス = new ListBox();
            btLapTime = new Button();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.Location = new Point(37, 84);
            btStart.Name = "btStart";
            btStart.Size = new Size(163, 50);
            btStart.TabIndex = 0;
            btStart.Text = "スタート";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(217, 84);
            btStop.Name = "btStop";
            btStop.Size = new Size(163, 50);
            btStop.TabIndex = 0;
            btStop.Text = "ストップ";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // lbTimeDisp
            // 
            lbTimeDisp.BackColor = Color.FromArgb(192, 255, 192);
            lbTimeDisp.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTimeDisp.Location = new Point(37, 22);
            lbTimeDisp.Name = "lbTimeDisp";
            lbTimeDisp.Size = new Size(343, 40);
            lbTimeDisp.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // tbReset
            // 
            tbReset.Location = new Point(37, 151);
            tbReset.Name = "tbReset";
            tbReset.Size = new Size(163, 48);
            tbReset.TabIndex = 2;
            tbReset.Text = "リセット";
            tbReset.UseVisualStyleBackColor = true;
            tbReset.Click += tbReset_Click;
            // 
            // ラップボックス
            // 
            ラップボックス.FormattingEnabled = true;
            ラップボックス.ItemHeight = 15;
            ラップボックス.Location = new Point(406, 22);
            ラップボックス.Name = "ラップボックス";
            ラップボックス.Size = new Size(173, 199);
            ラップボックス.TabIndex = 3;
            // 
            // btLapTime
            // 
            btLapTime.Location = new Point(217, 151);
            btLapTime.Name = "btLapTime";
            btLapTime.Size = new Size(163, 48);
            btLapTime.TabIndex = 4;
            btLapTime.Text = "ラップ";
            btLapTime.UseVisualStyleBackColor = true;
            btLapTime.Click += btLapTime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(591, 236);
            Controls.Add(btLapTime);
            Controls.Add(ラップボックス);
            Controls.Add(tbReset);
            Controls.Add(lbTimeDisp);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btStart;
        private Button btStop;
        private Label lbTimeDisp;
        private System.Windows.Forms.Timer timer1;
        private Button tbReset;
        private ListBox ラップボックス;
        private Button btLapTime;
    }
}
