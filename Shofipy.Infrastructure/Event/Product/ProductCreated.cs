using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shofipy.Infrastructure.Event.Product
{
    internal class ProductCreated
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}
