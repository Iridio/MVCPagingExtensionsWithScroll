using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
  public abstract class AggregateRoot
  {
    public Guid Id { get; private set; }

    public AggregateRoot()
    {
      Id = Guid.NewGuid();
    }
  }
}
