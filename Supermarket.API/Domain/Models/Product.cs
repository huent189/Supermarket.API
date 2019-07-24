using System;

namespace Supermarket.API.Domain.Models
{
    public class Product
    {
    public Guid Id { get; set; }
    public String Name { get; set; }
    public EUnitOfMeasurement Unit { get; set; }
    public int Quantity { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    }

    public enum EUnitOfMeasurement
    {
        Unity, Milligram, Gram, Kilogram, Liter
    }
}
