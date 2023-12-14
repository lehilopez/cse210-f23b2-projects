public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double CalculateTotalCost()
    {
        double cost = 0.0;

        foreach (Product product in _products)
        {
            cost = cost + product.CalculateProductCost();
        }

        if (_customer.LiveInUSA())
        {
            cost = cost + 5.0;
        }
        else
        {
            cost = cost + 35.0;
        }
        
        return cost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel = packingLabel + product.GetProductLabel() + Environment.NewLine;
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _customer.GetName() + Environment.NewLine + _customer.GetAddress();
        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}