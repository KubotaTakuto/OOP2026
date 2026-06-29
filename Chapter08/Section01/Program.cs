
namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();


        static void Main(string[] args) {
            string? pref, preCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了：ctrl+'Z'】");
            while (true) {
                Console.Write("都道府県：");
                pref = Console.ReadLine();
                if (pref == null) break;    //Ctrl+Zが押されたら入力終了
                Console.Write("県庁所在地：");
                preCaptalLocation = Console.ReadLine();

                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.Write("上書きしますか？（Y/N）：");
                    if (Console.ReadLine().Equals("Y")) {
                        prefOfficeDict[pref] = preCaptalLocation;
                    }
                } else {
                    prefOfficeDict[pref] = preCaptalLocation;
                }
            }

            while (true) {

                switch (menuDisp()) {
                    case 1:
                        allDisp();
                        break;
                    case 2:
                        searchPrefCaptalLocation();
                        break;
                    case 9:
                        break;
                }
                break;

                        //Console.WriteLine("****メニュー****");
                        //Console.WriteLine("1：一覧表示");
                        //Console.WriteLine("2：検索");
                        //Console.WriteLine("9：終了");
                        //Console.Write(">");

                        //int menunum = int.Parse(Console.ReadLine());
                        //switch (menunum) {
                        //    case 1:
                        //        foreach (var pre in prefOfficeDict) {
                        //            Console.WriteLine($"{pre.Key}の県庁所在地は{pre.Value}です。");
                        //        }
                        //        break;

                        //    case 2:
                        //        Console.Write("都道府県：");
                        //        var searchpref = Console.ReadLine();
                        //        Console.WriteLine($"{searchpref}の県庁所在地は{prefOfficeDict[searchpref]}です。");
                        //        break;

                        //    case 9:
                        //        break;
                        //}
                        //if (menunum == 9) break;
            }
        }

        private static int menuDisp() {
            Console.WriteLine("****メニュー****");
            Console.WriteLine("1：一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9：終了");
            Console.Write(">");

            return int.Parse(Console.ReadLine());
        }

        private static void allDisp() {
            foreach (var pre in prefOfficeDict) {
                Console.WriteLine($"{pre.Key}の県庁所在地は{pre.Value}です。");
            }
        }

        private static void searchPrefCaptalLocation() {
            Console.Write("都道府県：");
            var searchpref = Console.ReadLine();
            Console.WriteLine($"{searchpref}の県庁所在地は{prefOfficeDict[searchpref]}です。");
        }
    }
}
