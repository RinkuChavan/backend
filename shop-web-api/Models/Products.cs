using System;
using System.Collections.Generic;

namespace shop_web_api.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int? TypeId { get; set; }
        public virtual ProductType Type { get; set; }
    }
}
