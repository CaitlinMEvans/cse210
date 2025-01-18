class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private string _deliveryMethod;

    public Order(Customer customer, string deliveryMethod)
    {
        _customer = customer;
        _deliveryMethod = deliveryMethod;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.CalculateTotalCost();
        }

        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;
        switch (_deliveryMethod)
        {
            case "Floo Network":
                shippingCost += 20;
                break;
            case "Portkey":
                shippingCost += 50;
                break;
        }

        return productTotal + shippingCost;
    }

    public string ConvertToMagicalCurrency(decimal totalCost)
    {
        int galleons = (int)(totalCost / 10);
        decimal remaining = totalCost % 10;
        int sickles = (int)(remaining / 0.60m);
        int knuts = (int)((remaining % 0.60m) / 0.01m);

        return $"{galleons} Galleons, {sickles} Sickles, {knuts} Knuts";
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public string GetOrderDetails()
    {
        decimal totalCost = CalculateTotalCost();
        string magicalCurrency = ConvertToMagicalCurrency(totalCost);

        return $"{GetShippingLabel()}\n\n{GetPackingLabel()}\n" +
               $"Delivery Method: {_deliveryMethod}\n" +
               $"Total Cost: ${totalCost} ({magicalCurrency})";
    }
}