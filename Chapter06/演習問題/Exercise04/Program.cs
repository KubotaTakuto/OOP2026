using System.Text;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var array = line.Split(';', '=');
            for (int i = 0; i < array.Length; i += 2) {
                Console.WriteLine($"{ToJapanese(array[i])}：{array[i + 1]}");
            }

            //別解（foreach文）
            //var pair = line.Split(";");
            //foreach (var item in pair) {
            //    var word = item.Split("=");
            //    Console.WriteLine($"{ToJapanese(word[0])}:{word[1]}");
            //}

        }
        static string ToJapanese(string key) {
            return key switch {
                "Novelist" => "作家",
                "BestWork" => "代表作",
                "Born" => "誕生年",
                _ => "引数keyは、正しい値ではありません"
            };
            //古い書き方
            //switch (key) {
            //    case "Novelist":　
            //        return "作家";
            //    case "BestWork":
            //        return "代表作";
            //    case "Born":
            //        return "誕生年";
            //    default:
            //        return "引数keyは、正しい値ではありません";
            //}
        }
    }
}
