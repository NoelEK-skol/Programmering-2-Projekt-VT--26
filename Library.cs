public class Library
{
    protected List<Bok> böcker;

    public Library()
    {
        böcker = new List<Bok>();
    }

    public void AddBook(Bok bok)
    {
        böcker.Add(bok);
    }


    public List<Bok> GetAllBooks()
    {
        return böcker;
    }
}