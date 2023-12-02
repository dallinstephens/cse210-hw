public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string ReturnTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }

        totalPrice += ReturnShippingCost();

        // Reference on how to get 2 decimal places $"{value:0.00}":
        // https://stackoverflow.com/questions/164926/how-do-i-display-a-decimal-value-to-2-decimal-places
        return $"Total Price: ${totalPrice:0.00}\n";
    }

    private double ReturnShippingCost()
    {
        double shippingCost;

        if (_customer.IsInUSA())
        {
            shippingCost = 5;
            return shippingCost;
        }
        else
        {
            shippingCost = 35;
            return shippingCost;
        }
    }

    public string ReturnPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += product.ToString();
        }

        return packingLabel;
    }

    public string ReturnShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\n";

        return shippingLabel += _customer.ToString();
    }
}