using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Queries
{
  public interface IQueries<T> where T : AggregateRoot
  {
    IList<T> GetAll(int pageIndex, int pageSize, out int totalRecords);
    IList<T> GetAll(Expression<Func<T, bool>> where, int pageIndex, int pageSize, out int totalRecords);
  }
}
