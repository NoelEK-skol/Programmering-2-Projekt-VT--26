using Microsoft.Win32.SafeHandles;

partial class Program
{
    static void UserLoggedinLoad()
    {
        string[] lines = File.ReadAllLines("Users.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");
            if (parts.Length == 2)
            {
                string användarnamn = parts[0];
                string lösenord = parts[1];
                users.Add(new User(användarnamn, lösenord));
            }
        }
    }
}