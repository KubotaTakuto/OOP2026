
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("\n6.3.2");
            Exercise2(text);

            Console.WriteLine("\n6.3.3");
            Exercise3(text);

            Console.WriteLine("\n6.3.4");
            Exercise4(text);

            Console.WriteLine("\n6.3.5");
            Exercise5(text);

            Console.WriteLine("\n6.3.6");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine($"空白数：{count}");
        }

        private static void Exercise2(string text) {
            Console.Write("何の単語を置き換えますか：");
            string str1 = Console.ReadLine();
            Console.Write("置き換える文字：");
            string str2 = Console.ReadLine();
            var replaced = text.Replace(str1, str2);
            Console.WriteLine(replaced);
        }

        private static void Exercise3(string text) {
            //var words = text.Split(' ');
            //var sb = new StringBuilder();
            //foreach (var word in words) {
            //    if(word.Equals(' ')) {
            //        sb.Append(' ');
            //    } else {
            //        sb.Append(word);
            //    }
            //}
            //Console.WriteLine(sb.ToString());
        }


        private static void Exercise4(string text) {
            var words = text.Split(' ');
            Console.WriteLine(words.Length);
        }

        private static void Exercise5(string text) {
            var words = text.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length <= 4) {
                    Console.WriteLine(words[i]);
                }
            }
        }

        private static void Exercise6(string text) {
            //アルファベットの数を数えて表示
            var count = text.Count(c => c != ' ');
            Console.WriteLine($"文字数：{count}");
        }
    }
}
