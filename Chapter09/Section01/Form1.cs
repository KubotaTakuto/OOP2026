using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime dt1 = dtpDate.Value;
            tbOut2.Text = dt1.AddDays((double)nudDay.Value).ToString();
        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpBirth.Value;    //¶‚Ü‚ê‚½“ú
            DateTime today = DateTime.Today;    //¡“ú‚Ì“ú•t

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);

            tbOut.Text = "‚ ‚È‚½‚Í" + GetAge(birth, today) + "Î‚Å‚·";
            tbOut2.Text = (today - birth).Days + "“ú";
            tbOut3.Text = $"¶‚Ü‚ê‚½{birth.Month}Œ{birth.Day}“ú‚Í‘æ{NthWeek(birth)}T‚Ì{dayOfWeek}—j“ú‚Å‚·";
        }

        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }
    }
}
