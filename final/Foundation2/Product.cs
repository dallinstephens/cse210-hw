public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price * quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Product ID: {_id}, Quantity: {_quantity}\n";
    }
}