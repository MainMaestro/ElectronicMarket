using ElectronicMarket.Domain.Models;

namespace ElectronicMarket.Mvc.ViewModels;

public class HomeIndexViewModel
{
    public IEnumerable<Category> Categories { get; set; }
}
