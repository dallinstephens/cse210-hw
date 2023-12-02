// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit06/project-plan.html

using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        // Reference on how to underline text in terminal:
        // https://www.lihaoyi.com/post/BuildyourownCommandLinewithANSIescapecodes.html
        string startUnderline = "\u001b[4m";
        string endUnderline = "\u001b[0m";

        // Reference for United States address example:
        // https://www.google.com/search?q=byu+bookstore+address&sca_esv=586607062&ei=3KdoZbT4KsfAkPIP6P6g4AY&ved=0ahUKEwi01v3aguyCAxVHIEQIHWg_CGwQ4dUDCBA&uact=5&oq=byu+bookstore+address&gs_lp=Egxnd3Mtd2l6LXNlcnAiFWJ5dSBib29rc3RvcmUgYWRkcmVzczIGEAAYFhgeMgsQABiABBiKBRiGAzILEAAYgAQYigUYhgNI9yFQAFiRIHAAeAGQAQCYAbwBoAHzGKoBBDAuMjG4AQPIAQD4AQHCAgoQABiABBiKBRhDwgIFEC4YgATCAhEQLhiABBixAxiDARjHARjRA8ICExAuGIAEGIoFGLEDGIMBGNQCGEPCAhMQLhiDARjUAhixAxiABBiKBRhDwgILEC4YgAQYigUYkQLCAgsQLhiABBixAxiDAcICBRAAGIAEwgILEAAYgAQYsQMYgwHCAgsQLhiABBjHARivAcICIhAuGIAEGIoFGLEDGIMBGNQCGEMYlwUY3AQY3gQY4ATYAQHCAg0QLhixAxiABBiKBRhDwgIIEAAYgAQYsQPCAg4QLhiABBixAxjHARivAcICHBAuGLEDGIAEGIoFGEMYlwUY3AQY3gQY4ATYAQHCAg0QLhiABBiKBRixAxhDwgIjEC4YgAQYsQMYgwEYlwUY3AQY3gQY4AQY9AMY8QMY9QPYAQHCAg4QLhivARjHARixAxiABMICCxAuGK8BGMcBGIAEwgIdEC4YrwEYxwEYsQMYgAQYlwUY3AQY3gQY4ATYAQHCAhoQLhivARjHARiABBiXBRjcBBjeBBjgBNgBAcICBRAhGKABwgIFECEYqwLiAwQYACBB4gMFEgExIECIBgG6BgYIARABGBQ&sclient=gws-wiz-serp

        // Reference for Flintone characters:
        // https://www.google.com/search?q=flintstone+characters&sca_esv=586607062&ei=P6hoZeCZCNnJkPIPm5SVyAw&ved=0ahUKEwigtfWJg-yCAxXZJEQIHRtKBckQ4dUDCBA&uact=5&oq=flintstone+characters&gs_lp=Egxnd3Mtd2l6LXNlcnAiFWZsaW50c3RvbmUgY2hhcmFjdGVyczIOEAAYgAQYigUYkQIYsQMyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgARI3ElQ8gdYw0hwAngBkAEEmAHMAaAB2B-qAQYxLjMwLjG4AQPIAQD4AQGoAhTCAgoQABhHGNYEGLADwgINEAAYgAQYigUYsAMYQ8ICDhAAGOQCGNYEGLAD2AEBwgIWEC4YgAQYigUY1AIYyAMYsAMYQ9gBAsICExAuGIAEGIoFGMgDGLADGEPYAQLCAgoQABiABBiKBRhDwgIIEAAYgAQYsQPCAhMQABiABBiKBRjqAhi0AhhD2AEDwgITEC4YgAQYigUY6gIYtAIYQ9gBA8ICFhAAGAMYjwEY5QIY6gIYtAIYjAPYAQTCAhYQLhgDGI8BGOUCGOoCGLQCGIwD2AEEwgIREC4YgAQYsQMYgwEYxwEY0QPCAgsQABiABBixAxiDAcICCxAAGIAEGIoFGJECwgIKEC4YgAQYigUYQ8ICCxAuGJECGIAEGIoFwgIQEAAYgAQYigUYsQMYgwEYQ8ICExAAGIAEGIoFGLEDGIMBGMkDGEPCAgsQABiABBiKBRiSA8ICCBAAGIAEGJIDwgITEC4YgAQYigUYsQMYxwEY0QMYQ8ICDhAuGMcBGLEDGNEDGIAEwgIaEC4YkQIYgAQYigUYlwUY3AQY3gQY4ATYAQXCAg4QLhiRAhixAxiABBiKBcICBRAuGIAEwgIOEAAYgAQYigUYsQMYgwHCAg0QLhiABBiKBRixAxhDwgILEC4YgAQYsQMYgwHCAi8QLhiRAhixAxiABBiKBRiXBRjcBBjeBBjgBBj0AxjxAxj1Axj2Axj3Axj4A9gBBcICERAuGIAEGIoFGLEDGIMBGNQCwgILEAAYgAQYigUYsQPCAggQLhiABBjUAuIDBBgAIEHiAwUSATEgQIgGAZAGEboGBggBEAEYCboGBggCEAEYCLoGBAgDGAe6BgYIBBABGAq6BgYIBRABGBQ&sclient=gws-wiz-serp

        Address address1 = new Address("800 E Campus Dr", "Provo", "UT", "84602", "USA");
        Customer customer1 = new Customer("Fred Flintstone", address1);

        // Reference for products:
        // https://store.churchofjesuschrist.org/top-cat/clothing/men-s-clothing/men-s-white-clothing/5637160348.c
        Order order1 = new Order(customer1);
        Product product1 = new Product("Men's Cotton-Blend Dress Socks", "PI114900", 2.85, 4);
        Product product2 = new Product("Men's Microfiber Plain Knit Pleated Suit Trousers", "PI122800", 35.00, 2);
        Product product3 = new Product("Men's Adjustable Belt", "PI85070120", 6.80, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        Console.WriteLine($"{startUnderline}Order 1{endUnderline}:");
        Console.WriteLine(order1.ReturnPackingLabel());
        Console.WriteLine(order1.ReturnShippingLabel());
        // $5.00 is the shipping cost for shipping in the USA.
        // Total Price = 2.85 * 4 + 35.00 * 2 + 6.80 * 1 = 11.40 + 70.00 + 6.80 + 5.00 = 93.20
        Console.WriteLine(order1.ReturnTotalPrice());

        // Reference for Cananda address example:
        // https://www.google.com/search?q=cardston+bookshop+address&oq=cardston+bookshop+address&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRigAdIBCjEzNDkxajBqMTWoAgCwAgA&sourceid=chrome&ie=UTF-8

        Address address2 = new Address("226 Main St", "Cardston", "AB", "T0K 0K0", "Canada");
        Customer customer2 = new Customer("Betty Rubble", address2);

        // Reference for products:
        // https://store.churchofjesuschrist.org/top-cat/clothing/women-s-clothing/women-s-white-clothing/5637160353.c
        Order order2 = new Order(customer2);
        Product product4 = new Product("Women's Lindsey Dress", "PI85051609", 48.00, 1);
        Product product5 = new Product("Women's Pearly Shoe", "PI85056620", 10.71, 2);
        Product product6 = new Product("Women's Knee-High Nylons Stockings", "PI85060686", 2.50, 8);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        Console.WriteLine($"{startUnderline}Order 2{endUnderline}:");
        Console.WriteLine(order2.ReturnPackingLabel());
        Console.WriteLine(order2.ReturnShippingLabel());
        // $35.00 is the shipping cost for shipping outside the USA.
        // Total Price = 48.00 * 1 + 10.71 * 2 + 2.50 * 8 = 48.00 + 21.42 + 20.00 + 35.00 = 124.42
        Console.WriteLine(order2.ReturnTotalPrice());
    }
}