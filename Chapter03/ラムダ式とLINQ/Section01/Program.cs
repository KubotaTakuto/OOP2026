
namespace Section01 {
    internal class Program {

        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            var exists = cities.Exists(s => s[0] == 'B');   //頭文字がBの首都名を検索
            Console.WriteLine(exists);

            var name = cities.Find(s => s.Length == 6); //6文字の首都名を表示
            Console.WriteLine(name);

            var index = cities.FindIndex(s => s == "Berlin");   //Berlinがあるか検索
            Console.WriteLine(exists);

            var names = cities.FindAll(s => s.Length <= 5);   //5文字以上の首都名をすべて表示
            foreach (var s in names) { Console.WriteLine(s); }  //  配列の中にある文字を出力したい場合はforeachを使う
            //names.ForEach(s => Console.WriteLine(s));　//リストの場合のみforeachを短縮して使える

            var removedCount = cities.RemoveAll(s => s.Contains("on"));   //"on"が入っている首都名の数を数える
            Console.WriteLine(removedCount);

            //以下の条件を満たす物が存在するか調べる
            //【教科書P134～P137を参考に】
            //・文字数が6以上
            //・oを含む
            //・最後がn
            var target = cities.Exists(s => s.Length >= 6 && s.Contains('o') && s.EndsWith('n'));
            Console.WriteLine(target);
        }

    }
}
