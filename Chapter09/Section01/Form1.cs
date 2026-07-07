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

            tbAge.Text = "Ç†Ç»ÇΩÇÕ" + GetAge(birth, today) + "çŒÇ≈Ç∑";
            tbOut.Text = (today - birth).Days + "ì˙";
        }

        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
