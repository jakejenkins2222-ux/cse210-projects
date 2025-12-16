public class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St", "New York", "NY", "USA");
        Address a2 = new Address("456 Oak Rd", "Chicago", "IL", "USA");
        Address a3 = new Address("789 Park Ave", "Los Angeles", "CA", "USA");

        Lecture lecture = new Lecture("Tech Talk", "Learn to use computers", "March 10", "10:00 AM", a1, "Joseph Smith", 100);

        Reception reception = new Reception("Company Get Together", "Networking Event", "April 5", "6:00 PM", a2, "rsvp@company.com");

        OutdoorGathering outdoor = new OutdoorGathering("Summer Fun Festival", "Music and food", "June 20", "12:00 PM", a3, "Sunny");



        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("----------------------");

        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("----------------------");

        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }

}