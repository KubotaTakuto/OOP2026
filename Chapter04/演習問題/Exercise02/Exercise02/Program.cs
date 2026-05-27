
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        //P89～P90を参考に
        private static void Exercise1() {
            //if-else文を使用（コード4.9）
            var number = Console.ReadLine();
            if (int.TryParse(number, out int num)) {
                if (num >= 500) {
                    Console.WriteLine(num);
                } else if (num >= 100) {
                    Console.WriteLine(num * 3);
                } else if (num >= 0) {
                    Console.WriteLine(num * 2);
                } else {
                    Console.WriteLine(num);
                }
            } else {
                Console.WriteLine("入力に誤りがあります");
            }
        }

        private static void Exercise2() {
            //switch文を使用（コード4.10）

        }

        private static void Exercise3() {
            //switch式を使用（コード4.11）


        }
    }
}
