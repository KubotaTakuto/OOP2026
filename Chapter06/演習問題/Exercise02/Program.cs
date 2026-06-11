namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("整数文字列：");
            string stnum =  Console.ReadLine();
            if (int.TryParse(stnum, out int result)) {
                var num = result.ToString("#,0");
                Console.WriteLine(num);
                //Console.WriteLine($"{num:#,0}");
            } else {
                Console.WriteLine("整数文字列ではありません");
            }
        }
    }
}
