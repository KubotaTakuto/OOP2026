
using System.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];
            #region
            Console.WriteLine("\n7.1.1");
            Exercise1(numbers);

            Console.WriteLine("\n7.1.2");
            Exercise2(numbers);

            Console.WriteLine("\n7.1.3");
            Exercise3(numbers);

            Console.WriteLine("\n7.1.4");
            Exercise4(numbers);

            Console.WriteLine("\n7.1.5");
            Exercise5(numbers);
            #endregion
        }

        private static void Exercise1(int[] numbers) {
            var maxnum = numbers.Max();
            Console.WriteLine(maxnum);
        }

        private static void Exercise2(int[] numbers) {
            foreach (var lastarray in numbers.TakeLast(2))
                Console.WriteLine(lastarray);
        }

        private static void Exercise3(int[] numbers) {
            var fast0 = numbers.Select(n=>n.ToString("000")).ToArray();
            foreach(var num in fast0)
                Console.WriteLine(num);
        }

        private static void Exercise4(int[] numbers) {
            var min = numbers.Order().Take(3);
            foreach (var num in min) 
                Console.WriteLine(num);
        }

        private static void Exercise5(int[] numbers) {
            var over = numbers.Distinct().Count(x => x > 10);
            Console.WriteLine(over);
        }
    }
}
