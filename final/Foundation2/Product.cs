using System;

public class Product
{
    //attributes
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    //constructor
    public Product
        (string name,
         string id,
         float price,
         int quantity)
    {
        _name = name;
        _id = id;
        _price = (float)Math.Round(price,2);
        _quantity = quantity;
    }

    //methods
    public float GetTotalPrice()
    {
        return (float)Math.Round(_price * (float)_quantity,2);
    }
    public void ProductLabel()
    {
        Console.WriteLine($"{_name}:{_id}\n{_quantity} x {_price}");
    }
}