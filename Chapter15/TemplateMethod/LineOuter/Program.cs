using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\演習問題\exercise01_WPF\吾輩は猫である.txt";
TextProcessor.Run<LineCounterProcessor>(path);

public class LineCounterProcessor : TextProcessor{
    private int _count = 0;

    protected override void Initialize(string fname) =>
        _count = 0;

    protected override void Excute(string line) =>
        _count++;

    protected override void Terminate() =>
        Console.WriteLine("{0} 行", _count);
}
