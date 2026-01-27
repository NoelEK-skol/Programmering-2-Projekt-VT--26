using System.Runtime.InteropServices;

partial class Program
{
    static List<User> users = new List<User>
    {
        new User("user1", "lösenord")
    };
    static User loggedinUser = null!;
    static Library library = new Library();
    static bool running = true;
    static DateTime dt1 = DateTime.Now;

    static void Main()
    {
        while (running)
        {
            if (loggedinUser == null)
            {
                ShowStartMenu();
            }
            else
            {
                ShowMainMenu();
            }
        }
    }
}
