using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMarket.Domain.Models.Shop;

public class OrderItem : DbEntity
{
    public Product Product { get; set; }
    public string ProductId { get; set; }
    public int Count { get; set; }
}
