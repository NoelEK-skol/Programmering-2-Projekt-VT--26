class User
{
    public string Användarnamn { get; set; }
    public string Lösenord { get; set; }
    public User(string användarnamn, string lösenord)
    {
        Användarnamn = användarnamn;
        Lösenord = lösenord;
    }
}