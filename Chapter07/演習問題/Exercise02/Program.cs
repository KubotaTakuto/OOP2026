using Section01;
using System.Data;    //Section01プロジェクトにあるBookクラスを利用

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET Core", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };
            #region
            Console.WriteLine("\n7.2.1");
            Exercise1(books);

            Console.WriteLine("\n7.2.2");
            Exercise2(books);

            Console.WriteLine("\n7.2.3");
            Exercise3(books);

            Console.WriteLine("\n7.2.4");
            Exercise4(books);

            Console.WriteLine("\n7.2.5");
            Exercise5(books);

            Console.WriteLine("\n7.2.6");
            Exercise6(books);

            Console.WriteLine("\n7.2.7");
            Exercise7(books);
            #endregion
        }

        private static void Exercise1(List<Book> books) {
            //P166
            foreach (Book book in books.Where(b => b.Title == "ワンダフル・C#ライフ")) { 
            Console.WriteLine(book.Price + " " + book.Pages);
            }
        }

        private static void Exercise2(List<Book> books) {
            var cnt = books.Count(x => x.Title.Contains("C#"));
            Console.WriteLine(cnt);

            //Console.WriteLine(books.Count(x => x.Title.Contains("C#")));
        }

        private static void Exercise3(List<Book> books) {
            var avg = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
            Console.WriteLine(avg);

            //Console.WriteLine(books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages));
        }

        private static void Exercise4(List<Book> books) {
            var title = books.FirstOrDefault(x => x.Price >= 4000);
            Console.WriteLine(title.Title);

            //Console.WriteLine(books.FirstOrDefault(x => x.Price >= 4000));
        }

        private static void Exercise5(List<Book> books) {
            var maxpage = books.Where(x => x.Price < 4000).Max(x => x.Pages);
            Console.WriteLine(maxpage);

            //Console.WriteLine(books.Where(x => x.Price < 4000).Max(x => x.Pages));
        }

        private static void Exercise6(List<Book> books) {
            var allwrite = books.Where(x => x.Pages >= 400).OrderByDescending(x=>x.Price);
            foreach (var book in allwrite) {
                Console.WriteLine(book.Title + "　" + book.Price);
            }
        }

        private static void Exercise7(List<Book> books) {
            var all = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            foreach (var book in all) {
                Console.WriteLine(book.Title);
            }

            //var all = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500).Select(b => b.Title);
            //foreach (var book in all) {
            //    Console.WriteLine(book);
            //}
        }
    }
}
