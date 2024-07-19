using System;
using System.Reflection.Emit;
public class Order
{
    private List<Product> _products;
    private List <Customer> _customers;


    public Order()
    {
        _products = new List<Product>();
        _customers = new List<Customer>();
    }


    public double CalculateOrderTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateProductTotal();
        }
        
        double shippingCost = 0;
        foreach (Customer customer in _customers)
        {
            if (customer.IsUsa())
            {
                shippingCost += 5;
            }
            else
            {
                shippingCost += 35;
            }
        }
        
        total += shippingCost;
        return total;
    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetProductName()}, ID: {product.GetProductId()}\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        string label = "Shipping Label:\n";
        foreach (Customer customer in _customers)
        {
            label += $"Customer Name: {customer.GetCustomerName()}\n";
            label += $"Address:\n{customer.GetAddress().CompleteAddress()}";
        }
        return label;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
}