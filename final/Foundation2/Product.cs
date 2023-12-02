public class Product
{
    private string _name;
    private string _id;
    private double _price;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price * quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Product ID: {_id}\n";
    }
}