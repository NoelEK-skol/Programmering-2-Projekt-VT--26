partial class Program
{
    static void SearchBook()
    {
        string fil = "Textfil.txt";
        Console.WriteLine("Sök efter bok:");
        string sökning = Console.ReadLine();

        Console.WriteLine("Böcker som hittades:"); //ifall filen innehåller
        foreach (string a in File.ReadLines(fil))
        {
            if (a.Contains(sökning))
            {
                Console.WriteLine(a);
            }
        }
        if(!File.ReadLines(fil).Any(line => line.Contains(sökning))) //ifall filen inte innehåller
        {
            Console.WriteLine("Ingen bok hittades");
        }
    }
}