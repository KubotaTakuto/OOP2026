
using System.ComponentModel.Design;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_1(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.2 *****");
            Exercise2_2(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.3 *****");
            Exercise2_3(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.4 *****");
            Exercise2_4(cities);
            Console.WriteLine();
        }

        private static void Exercise2_1(List<string> cities) {
            //できたらGitのコメント「問題3.2.1完成」
            Console.Write("検索首都名：");
            string target = Console.ReadLine();
            var Exists = cities.FindIndex(s => s.Equals (target));
                Console.WriteLine(Exists);
        }

        private static void Exercise2_2(List<string> cities) {
            //できたらGitのコメント「問題3.2.2完成」
            var Exists = cities.Count(s => s.Contains('o'));
            Console.WriteLine(Exists);
        }

        private static void Exercise2_3(List<string> cities) {
            //できたらGitのコメント「問題3.2.3完成」
            var Key = cities.Where(s => s.Contains('o')).ToArray();
            foreach(var key in Key) Console.WriteLine(key);
        }

        private static void Exercise2_4(List<string> cities) {
            //できたらGitのコメント「問題3.2.4完成」
            var name = cities.Where(s => s.StartsWith('B')).Select(s => s.Length);
            foreach(var Name  in name) Console.WriteLine(Name);

            //問題3.2.4解説
            Console.WriteLine("");
            var nanne = cities.Where(s => s.StartsWith('B')).Select(s => new {s, s.Length});
            foreach (var Nanne in nanne) Console.WriteLine(Nanne.s + ":" + Nanne.Length + "文字");
        }
    }
}
