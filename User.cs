class User : Person
{
    public string Lösenord { get; set; }
    public User(string användarnamn, string lösenord) : base(användarnamn)
    {
        Lösenord = lösenord;
    }
}