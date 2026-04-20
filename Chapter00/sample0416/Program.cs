namespace sample0416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 33550336)
            {
                Console.WriteLine("Hello, World!");
                i++;
            }
            Console.WriteLine(i+"回繰り返しました。");
        }
    }
}
