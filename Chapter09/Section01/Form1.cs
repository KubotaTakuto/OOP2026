using Microsoft.VisualBasic;
using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime dt1 = dtpDate.Value;
            tbOut.Text = dt1.AddDays((double)nudDay.Value).ToString();
        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpBirth.Value;    //ê∂Ç‹ÇÍÇΩì˙
            DateTime today = DateTime.Today;    //ç°ì˙ÇÃì˙ït

            int age = (today.Year - birth.Year);
            if(today < birth.AddYears(age)) {
                age--;
            }
            tbAge.Text = "Ç†Ç»ÇΩÇÕ" + age + "çŒÇ≈Ç∑";
            tbOut.Text = (today - birth).Days + "ì˙";
        }
    }
}
