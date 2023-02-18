using System;

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public double Price { get; set; }

    public int CompareTo(Product other)
    {
        if (other == null) return 1;

        return Price.CompareTo(other.Price);
    }
}