using System;
using System.Collections.Generic;

namespace shop_web_api.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
    }
}
