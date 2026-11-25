class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal total = 0m;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUsa())
        {
            return total + 5m;
        }

        return total + 35m;
    }
    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
    public string GetPackingLabel()
    {
        List<string> lines = new List<string>();

        foreach (Product product in _products)
        {
            lines.Add($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        return string.Join("\n", lines);
    }
}