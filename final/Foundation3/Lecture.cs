public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetFullDetails()
    {
        return GetStandardDetails() + " Event Type: Lecture" + "\n" + " Speaker: " + _speaker + "\n" + " Capacity: " + _capacity;
    }

    public string GetShortDescription()
    {
        return "Lecture: " + GetTitle() + " on " + GetDate() + "\n";
    }
}
