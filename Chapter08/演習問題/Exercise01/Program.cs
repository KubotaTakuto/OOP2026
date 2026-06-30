
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cpzy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            var dict = new Dictionary<char, int>();
            var array = text.ToUpper().Order();
            foreach (var ch in array) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            foreach (var alph in dict) {
                Console.WriteLine($"'{alph.Key}':{alph.Value}");
            }

            //別解
            //foreach (var ch in text.ToUpper()) {
            //    if ('A' <= ch && ch <= 'Z') {
            //        if (dict.ContainsKey(ch)) {
            //            dict[ch]++;
            //        } else {
            //            dict[ch] = 1;
            //        }
            //    }
            //}

            //foreach (var alph in dict.OrderBy(x => x.Key)) {
            //    Console.WriteLine($"'{alph.Key}':{alph.Value}");
            //}
        }

        private static void Exercise2(string text) {
            var dict = new SortedDictionary<char, int>();
            var array = text.ToUpper();
            foreach (var ch in array) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            foreach (var alph in dict) {
                Console.WriteLine($"'{alph.Key}':{alph.Value}");
            }

            //別解
            //foreach (var ch in text.ToUpper()) {
            //    if ('A' <= ch && ch <= 'Z') {
            //        if (dict.ContainsKey(ch)) {
            //            dict[ch]++;
            //        } else {
            //            dict[ch] = 1;
            //        }
            //    }
            //}

            //foreach (var alph in dict.OrderBy(x => x.Key)) {
            //    Console.WriteLine($"'{alph.Key}':{alph.Value}");
            //}
        }
    }
}
