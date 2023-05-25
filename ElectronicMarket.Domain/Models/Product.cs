using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMarket.Domain.Models;
public class Product : DbEntity
{
    public string Name { get; set; }
    public Category Category { get; set; }
}
