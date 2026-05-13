namespace Exercise02 {
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
    }
}
