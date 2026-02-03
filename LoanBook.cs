partial class Program
{
    static void LoanBook()
    {
        string[] lines = File.ReadAllLines("Textfil.txt");
        foreach(string line in lines)
        {
            string[] parts = line.Split(", ");
            if (parts.Length == 3)
            {
                string titel = parts[0];
                string författare = parts[1];
                string genre = parts[2];
                Console.WriteLine($"{titel}, {författare}, {genre}");
            }
        }
    }
}