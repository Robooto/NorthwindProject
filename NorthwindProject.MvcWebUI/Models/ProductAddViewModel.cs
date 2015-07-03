using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthwindProject.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public Entities.Concrete.Product Product { get; set; }

        public List<System.Web.Mvc.SelectListItem> Categories { get; set; }
    }
}
