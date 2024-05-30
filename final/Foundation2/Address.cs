using System;

public class Address
{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _stateside;

    //Constructor
    public Address
            (
                string streetAddress,
                string city,
                string state,
                string country,
                bool stateside
            )
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _stateside = stateside;
    }
    //methods
    public bool verifyStateside()
    {
        return _stateside;
    }
    public void PrintAddress()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}, {_state}\n{_country}");
    }

}