using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
  public class ProductQueries : IQueries<Product>
  {
    private IList<Product> products;
    public ProductQueries()
    {
      products = new List<Product>();
      for (int i = 0; i < 200; i++)
        products.Add(new Product(String.Format("product{0}", i), i * 1.75M));
    }

    public IList<Product> GetAll(int pageIndex, int pageSize, out int totalRecords)
    {
      return GetAll(null, pageIndex, pageSize, out totalRecords);
    }

    public IList<Product> GetAll(Expression<Func<Product, bool>> where, int pageIndex, int pageSize, out int totalRecords)
    {
      pageIndex--;
      if (pageIndex < 0)
        pageIndex = 0;
      totalRecords = 0;
      IList<Product> result = new List<Product>();
      var query = products.AsQueryable();
      if (where != null)
        query = query.Where(where);
      totalRecords = query.Count();
      if (pageSize > 0)
        result = query.Skip(pageIndex * pageSize).Take(pageSize).ToList();
      else
        result = query.ToList();
      return result;
    }
  }
}
