partial class Program
{
    static void SearchBook()
    {
        string fil = "Textfil.txt";
        Console.WriteLine("Sök efter bok:");
        string sökning = Console.ReadLine();

        Console.WriteLine("Böcker som hittades:");
        foreach (string a in File.ReadLines(fil))
        {
            if (a.Contains(sökning))
            {
                Console.WriteLine(a);
            }
        }
        if(!File.ReadLines(fil).Any(line => line.Contains(sökning)))
        {
            Console.WriteLine("Ingen bok hittades");
        }
    }
}