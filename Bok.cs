public class Bok : LibraryBas
{
    public string Genre { get; set; }

    public Bok(string titel, string författare, string genre) : base(titel, författare)
    {
        Genre = genre;
    }

    public override string Info()
    {
        return $"{Titel} av {Författare} {Genre}";
    }
}