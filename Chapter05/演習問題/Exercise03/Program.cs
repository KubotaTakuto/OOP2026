using Exercise01;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var ym1 = new YearMonth(1990, 5);
            var ym2 = new YearMonth(1990, 5);

            if (ym1 == ym2) {
                Console.WriteLine("ym1とym2は等しい");
            } else {
                Console.WriteLine("ym1とym2は等しくない");
            }
        }
    }
}
