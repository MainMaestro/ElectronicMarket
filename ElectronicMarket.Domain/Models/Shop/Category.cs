using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMarket.Domain.Models.Shop;

public class Category :DbEntity
{
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public string Description { get; set; }
}
