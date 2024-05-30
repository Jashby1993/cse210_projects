using System;
using System.Collections.Generic;

public class Order
{
    //attributes
    private Customer _customer;
    private List<Product> PackingList;

    //constructor
    public Order(Customer customer)
    {
        _customer = customer;
        List<Product> PackingList = new List<Product>();
    }

    //methods
    public void AddToCart(Product product)
    {
        PackingList.Add(product);
    }
    public float ChargeShipping()
    {
        
        if (_customer.CustomerStatesideStatus())
        {
            return 5.00F;
        }
        else
        {
            return 35.00F;
        }
    }
    public float TotalCost()
    {
        float runningTotal = 0.00F;
        foreach (Product product in PackingList)
        {
            runningTotal += product.GetTotalPrice();
        }
        return ChargeShipping() + runningTotal;
    }
    public void PrintShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        _customer.DisplayAddress();        
    }
}