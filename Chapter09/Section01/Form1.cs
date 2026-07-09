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
            DateTime birth = dtpBirth.Value.Date;    //¶‚Ü‚ê‚½“ú
            DateTime today = DateTime.Today;    //¡“ú‚Ì“ú•t

            tbOut.Text = "‚ ‚È‚½‚Í" + GetAge(birth, today) + "Î‚Å‚·";
            tbOut2.Text = (today - birth).Days + "“ú";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);

            tbOut3.Text = $"¶‚Ü‚ê‚½{birth.Month}Œ{birth.Day}“ú‚Í‘æ{NthWeek(birth)}T‚Ì{dayOfWeek}—j“ú‚Å‚·";

            if (birth.Month == today.Month) {
                if (birth.Day == today.Day) {
                    tbOut4.Text = $"’a¶“ú‚Í¡“ú‚Å‚·B";
                } else if (birth.Day > today.Day) {
                    tbOut4.Text = $"’a¶“ú‚Ü‚Å‚ ‚Æ{birth.Day - today.Day}“ú‚Å‚·";
                } else {
                    DateTime nextBirth = new DateTime(today.Year + 1, birth.Month, birth.Day);
                    tbOut4.Text = $"’a¶“ú‚Ü‚Å‚ ‚Æ{(nextBirth - today).Days}“ú‚Å‚·";
                }
            } else if (birth.Month < today.Month || (birth.Month < today.Month && birth.Day < today.Day)) {
                DateTime nextBirth = new DateTime(today.Year + 1, birth.Month, birth.Day);
                tbOut4.Text = $"’a¶“ú‚Ü‚Å‚ ‚Æ{(nextBirth - today).Days}“ú‚Å‚·";
            } else {
                DateTime nextBirth = new DateTime(today.Year, birth.Month, birth.Day);
                tbOut4.Text = $"’a¶“ú‚Ü‚Å‚ ‚Æ{(nextBirth - today).Days}“ú‚Å‚·";
            }

            //‰ğ“š—á
            ////¡”N‚Ì’a¶“ú‚ğì¬‚·‚é
            //DateTime thisYearBirthday = new DateTime(today.Year, birth.Month, birth.Day);
            ////Šù‚É’a¶“ú‚ª‰ß‚¬‚½‚©H
            //if(thisYearBirthday < today) {
            //    //—ˆ”N‚Ì’a¶“ú‚ğì¬‚·‚é
            //    thisYearBirthday = thisYearBirthday.AddYears(1);
            //}

            //var span = thisYearBirthday - today;

            //if (span.Days == 0) {
            //    tbOut4.Text = "’a¶“ú‚Í¡“ú‚Å‚·B";
            //} else {
            //    tbOut4.Text = $"’a¶“ú‚Ü‚Å‚ ‚Æ{span.Days}“ú‚Å‚·";
            //}
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
