using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handson4.Models
{
    public class Brand
    {
        public string BrandId { get; set; }
        public string Name { get; set; }
        public static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId = "B001", Name = "Haro"},
            new Brand(){BrandId = "B002", Name = "Electra"},
            new Brand(){BrandId = "B003", Name = "Heller"},
            new Brand(){BrandId = "B004", Name = "Trek"}
        };
    }
}