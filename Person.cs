public abstract class Person
{
    protected string användarnamn;

    public string Användarnamn
    {
        get {return användarnamn;}
        set {användarnamn = value;}
    }

    public Person(string användarnamn)
    {
        this.användarnamn = användarnamn;
    }
}