using TextFileProcessorDI;

var service = new LineCounterService();
var processor = new TextFileProcessor(service);
Console.Write("パスを入力：");
processor.Run(Console.ReadLine());
