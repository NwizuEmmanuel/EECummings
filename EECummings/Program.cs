internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter some words: ");
        var words = Console.ReadLine();

        words = words!.Replace(",", "\t");
        Console.WriteLine(words);
    }
}