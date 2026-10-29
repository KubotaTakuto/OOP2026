using Exercise03;
using System.IO;

var service = new Take20Service();
var processor = new TextFileProcessor(service);
Console.Write("パスを入力：");
string? path = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(path)) {
    path = path.Trim().Trim('"');
    processor.Run(path);
}