﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.DTOs
{
    public class ProductAddDto
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public string UserId { get; set; }
    }
}
