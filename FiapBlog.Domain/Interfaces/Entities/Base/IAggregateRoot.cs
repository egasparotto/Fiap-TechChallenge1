using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Domain.Interfaces.Entities.Base
{
    public interface IAggregateRoot
    {
        int Id { get; set; }
    }
}
