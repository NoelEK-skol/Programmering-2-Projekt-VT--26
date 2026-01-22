public class Bok
{
    public string Titel { get; set; }
    public string Författare { get; set; }
    public string Genre { get; set; }

    public Bok(string titel, string författare, string genre)
    {
        Titel = titel;
        Författare = författare;
        Genre = genre;
    }
}