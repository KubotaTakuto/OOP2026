using System.Globalization;

namespace Execrcise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            tbOut1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
        }

        private void btButton2_Click(object sender, EventArgs e) {
            tbOut2.Text = DateTime.Now.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b");
        }

        private void btButton3_Click(object sender, EventArgs e) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbOut3.Text = DateTime.Now.ToString("gg y”N MŒŽ d“ú(dddd)",culture);
        }
    }
}
