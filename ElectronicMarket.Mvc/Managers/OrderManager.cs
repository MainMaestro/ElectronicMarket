using ElectronicMarket.Domain.Models.Shop;
using ElectronicMarket.Mvc.Data;

namespace ElectronicMarket.Mvc.Managers;

public class OrderManager
{
    private readonly ApplicationDbContext _context;

    public OrderManager(ApplicationDbContext context)
    {
        _context = context;
    }
    public Order CreateOrder(Cart cart)
    {
        //TODO: implement
        return new Order();
    }
}
