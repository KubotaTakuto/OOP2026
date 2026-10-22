using System.Text.RegularExpressions;
using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";

Console.Write("カウントしたい単語：");
string? word = Console.ReadLine();
WordCounterProcessor.Word = word;

TextProcessor.Run<WordCounterProcessor>(path);

//コメントは解答例
public class WordCounterProcessor : TextProcessor {
    public static string Word { get; set; }
    //private string Word = "";
    private int _count = 0;

    protected override void Initialize(string fname) => _count = 0;
    //protected override void Initialize(string fname) {
    //    _count = 0;
    //    Console.Write("カウントしたい単語：");
    //    Word = Console.ReadLine();
    //}

    protected override void Excute(string line) =>
        _count += Regex.Matches(line, Regex.Escape(Word)).Count;

    protected override void Terminate() => Console.WriteLine($"「{Word}」は {_count} 回出現します");
}
