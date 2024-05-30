using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street",
                                        "Rexburg",
                                        "Idaho",
                                        "United States",
                                        true);
        Address endereco2 = new Address("456 Avenida Principal",
                                        "Manaus",
                                        "Amazonas",
                                        "Brasil",
                                        false);
        Customer customer1 = new Customer("John Smith",address1);
        Customer cliente2 = new Customer("Joao Silva",endereco2);
        Product product1 = new Product("Dice Set","d4d6d8d10d12d20",13.46F,2);
        Product product2 = new Product("DnD Rule Book","5e122018",25.94F,1);
        Product product3 = new Product("Figurine","3kbbtrkak",9.76F,4);
        Product product4 = new Product("Laptop","3550denvhyp",1999.98F,1);
        Product product5 = new Product("Monitor","Asus12345000",289.67F,2);
        Product product6 = new Product ("Compressed Air","n33dm0r3",5.79F,17);
        Order order1 = new Order(customer1);
        Order order2 = new Order(cliente2);
        order1.AddToCart(product1);
        order1.AddToCart(product2);
        order1.AddToCart(product3);
        order2.AddToCart(product4);
        order2.AddToCart(product5);
        order2.AddToCart(product6);

        Console.WriteLine("Order 1 info:");
        order1.PrintPackingList();
        order1.PrintShippingLabel();
        Console.WriteLine($"Total Cost:{order1.TotalCost()}");

        Console.WriteLine("Order 2 info:");
        order2.PrintPackingList();
        order2.PrintShippingLabel();
        Console.WriteLine($"Total Cost:{order2.TotalCost()}");

    }
}