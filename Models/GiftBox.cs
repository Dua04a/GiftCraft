using System.Collections.Generic;
using System.Linq;

namespace GiftCraft.Models;

public class GiftBox
{
    public List<Product> Products { get; } = new();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal TotalPrice()
    {
        return Products.Sum(product => product.Price);
    }
}