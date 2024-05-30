using System;

public class Customer
{
    //attributes
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

//methods
    public string GetName()
    {
        return _name;
    }
    public bool CustomerStatesideStatus()
    {
        return _address.verifyStateside();
    }
    public void DisplayAddress()
    {
        _address.PrintAddress();
    }
}