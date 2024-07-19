using System;
public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;


    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }


    public bool IsUsa()
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
    public string CompleteAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}\n{_country}";
    }
}