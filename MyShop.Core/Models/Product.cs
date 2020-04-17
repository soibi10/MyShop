﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }




        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
