using System.IO.Compression;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _zip;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string zip, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _zip = zip;
        _country = country;
    }

    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_stateOrProvince} {_zip}\n{_country}\n";
    }
}