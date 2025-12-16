public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + " Event Type: Reception" + "\n" + " RSVP Email: " + _rsvpEmail;
    }

    public string GetShortDescription()
    {
        return "Reception: " + GetTitle() + " on " + GetDate() + "\n";
    }
}