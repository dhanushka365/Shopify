using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shofipy.Infrastructure.Command.Product
{
    public class CreateProduct
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; } = string.Empty;

        public float ProductPrice { get; set; }

        public Guid CategoryId { get; set; }


    
    }
}
