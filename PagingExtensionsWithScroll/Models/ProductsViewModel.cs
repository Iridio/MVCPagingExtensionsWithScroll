using Domain.Entities;
using System.Collections.Generic;

namespace PagingExtensionsWithScroll.Models
{
  public class ProductsViewModel
  {
    public IList<Product> Products { get; set; }
    public int Page { get; set; }
    public int PageSize { get { return 10; } }
    public int TotalRecords { get; set; }
  }
}