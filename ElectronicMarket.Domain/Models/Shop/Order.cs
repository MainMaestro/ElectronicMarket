﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMarket.Domain.Models.Shop;

public class Order : DbEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public Product Product { get; set; }
    public int ProductId { get; set; }

}
