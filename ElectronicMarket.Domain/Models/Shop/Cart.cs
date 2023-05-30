using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMarket.Domain.Models.Shop;

public class Cart : DbEntity
{
    public string UserId { get; set; }
    public IdentityUser User { get; set; }
    public ICollection<OrderItem> Items{ get; set; }=new List<OrderItem>();
    
    
    
}
