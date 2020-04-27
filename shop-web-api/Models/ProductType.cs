using System;
using System.Collections.Generic;

namespace shop_web_api.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Products>();
        }

        public int TypeId { get; set; }
        public string ProductType1 { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
