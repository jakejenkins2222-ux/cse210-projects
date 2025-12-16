public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return "\n" + "Title: " + _title + "\n" + " Description: " + _description + "\n" + " Date: " + _date + "\n" + " Time: " + _time + "\n" + " Address: " + _address.GetFullAddress() + "\n";
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }
}