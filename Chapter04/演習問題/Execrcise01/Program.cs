namespace Execrcise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            Console.WriteLine("---4.1.1---");
            //foreah文
            Console.WriteLine("foreach文で出力");
            var lang = langs.FindAll(s => s.Contains('S'));
            foreach (string s in lang) {
                Console.WriteLine(s);
            }

            //for文
            Console.WriteLine("\nfor文で出力");
            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
            }

            //while文
            Console.WriteLine("\nwhile文で出力");
            var flag = true;
            while (flag == true) {
                if (langs.Contains("S")) {
                    Console.WriteLine(langs);
                    flag = false;
            }
        }
        }

        private static void Exercise2(List<string> langs) {
            Console.WriteLine("---4.1.2---");
            //LINQを使用する（Where）
        }

        private static void Exercise3(List<string> langs) {
            Console.WriteLine("---4.1.3---");
            //Swicth式を使用

        }
    }
}
