using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
  public class Product : AggregateRoot
  {
    public string Title { get; private set; }
    public decimal Price { get; private set; }

    public Product(string title, decimal price)
    {
      Title = title;
      Price = price;
    }
  }
}
