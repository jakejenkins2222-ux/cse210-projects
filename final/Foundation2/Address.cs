using System;

class Address
{
private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public void DisplayAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine(_city + ", " + _stateOrProvince);
        Console.WriteLine(_country);
    }
}
