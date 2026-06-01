
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
            Console.Write("整数を入力してください：");
            string? number = Console.ReadLine();
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
                Console.WriteLine("入力値に誤りがあります");
            }
        }

        private static void Exercise2() {
            //switch文を使用（コード4.10）
            Console.Write("整数を入力してください: ");
            string? number = Console.ReadLine();

            if (int.TryParse(number, out int num)) {
                switch (num) {
                    case int n when n < 0:
                        Console.WriteLine(n);
                        break;

                    case int n when n < 100:
                        Console.WriteLine(n * 2);
                        break;

                    case int n when n < 500:
                        Console.WriteLine(n * 3);
                        break;

                    default:
                        Console.WriteLine(num);
                        break;
                }
            } else {
                Console.WriteLine("入力値に誤りがあります");
            }
        }

        private static void Exercise3() {
            //switch式を使用（コード4.11）
            Console.Write("整数を入力してください: ");
            string? number = Console.ReadLine();

            if (int.TryParse(number, out int num)) {
                int result = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                    _ => num
                };

                Console.WriteLine(result);
            } else {
                Console.WriteLine("入力値に誤りがあります");
            }
        }
    }
}
