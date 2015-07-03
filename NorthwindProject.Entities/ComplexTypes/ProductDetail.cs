using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entities.ComplexTypes
{
    // Join of multiple tables, not database entity
    public class ProductDetail
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public string QuantityPerUnity { get; set; }

        public decimal UnityPrice { get; set; }

        public short? UnitsInStock { get; set; }
    }
}
