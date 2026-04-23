

namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length == 3
                && int.TryParse(args[1], out var start)
                && int.TryParse(args[2], out var stop)
                && start <= stop) {
                if (args.Length >= 1 && args[0] == "-tof") {
                    PrintMeterToFeetList(start, stop);
                } else if (args.Length >= 1 && args[0] == "-tom") {
                    PrintFeetToMeterList(start, stop);
                } else {
                    Console.WriteLine("引数エラー");
                }
            } else {
                Console.WriteLine("引数エラー");
            }
        }

        static void PrintMeterToFeetList(int start, int stop) {
            //メートルからフィートへの対応表を出力
            for (int meter = start; meter <= stop; meter++) {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }

        static void PrintFeetToMeterList(int start, int stop) {
            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
    }
}
