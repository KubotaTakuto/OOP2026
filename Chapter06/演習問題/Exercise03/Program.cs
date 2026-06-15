
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
            //やらなくていい
            string[] words = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words) {
                if (sb.Length == 0) {
                    sb.Append(word);
                } else {
                    sb.Append(" ");
                    sb.Append(word);
                }
            }
            sb.Append('.');
            Console.WriteLine(sb);
        }


        private static void Exercise4(string text) {
            var words = text.Split(' ');
            Console.WriteLine(words.Length);
        }

        private static void Exercise5(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words)
                Console.WriteLine(word);
            //1行で即時実行
            //text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);

            //自分で書いた
            //var words = text.Split(' ');
            //for (int i = 0; i < words.Length; i++) {
            //    if (words[i].Length <= 4) {
            //        Console.WriteLine(words[i]);
            //    }
            //}
        }

        private static void Exercise6(string text) {
            //アルファベットの数を数えて表示
            var str = text.ToLower().Replace(" ", "");

            //辞書（ディクショナリ）を使った集計
            var alphDicCount = Enumerable.Range('a', 26)
                            .ToDictionary(num => ((char)num), num => 0);

            //var dict = new SortedDictionary<char, int>();
            foreach (var c in str) {
                alphDicCount[c]++;
            }

            foreach (var word in alphDicCount) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }

            Console.WriteLine();    //改行

            //配列を用いた集計
            var array = Enumerable.Repeat(0, 26).ToArray();
            foreach (var alph in str) {
                array[alph - 'a']++;
            }

            for (var ch = 'a'; ch < 'z'; ch++) {
                Console.WriteLine($"{ch}:{array[ch - 'a']}");
            }

            Console.WriteLine();   //改行

            //'a'から順にカウントして集計
            for (char ch = 'a'; ch < 'z'; ch++) {
                Console.WriteLine($"{ch}:{str.Count(c => c == ch)}");
                //                             ラムダ式⤴
            }
        }
    }
}
