namespace Test01_01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要：カンマ区切りで分割
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var student = line.Split(',');
                var total = new Student {
                    Name = student[0],
                    Subject = student[1],
                    Score = int.Parse(student[2])
                };
                students.Add(total);
            }
            return students;
        }

        //メソッドの概要：科目別合計
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;
                else dict[student.Subject] = student.Score;
            }
            return dict;
        }
    }
}
