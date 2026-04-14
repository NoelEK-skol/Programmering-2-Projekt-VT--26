public abstract class LibraryBas
{
    protected string titel;
    protected string författare;

    public string Titel
    {
        get {return titel;}
        set {titel = value;}
    }

    public string Författare
    {
        get {return författare;}
        set {författare = value;}
    }

    public LibraryBas(string titel, string författare)
    {
        this.titel = titel;
        this.författare = författare;
    }

    public virtual string Info()
    {
        return $"{titel} av {författare}";
    }
    
}