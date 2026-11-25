class Product
{
    private string _name;
    private string _productId;
    private decimal _unitPrice;
    private int _quantity;

    public Product(string name, string productId, decimal unitPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetTotalCost()
    {
        return _unitPrice * _quantity;
    }
}