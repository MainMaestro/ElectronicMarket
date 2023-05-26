using ElectronicMarket.Domain.Models.Shop;
using ElectronicMarket.Mvc.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ElectronicMarket.Mvc.Managers;

public class CartManager
{
    private readonly ApplicationDbContext context;
    private readonly UserManager<IdentityUser> userManager;

    public CartManager(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        this.context = context;
        this.userManager = userManager;
    }
    private Cart Create(string userId)
    {
        var cart = new Cart {UserId=userId}; 
        context.Carts.Add(cart);
        context.SaveChanges();
        return cart;

    }
    private String GetUserId(ClaimsPrincipal user)
    {
        return userManager.GetUserId(user);
    }
    public Cart AddProduct(ClaimsPrincipal user, Product product)
    {
        var userId = GetUserId(user);
        var cart = context.Carts.Include(c => c.Products).FirstOrDefault(c=>c.UserId==userId);
        if (cart==null)
        cart= Create(userId);
        cart.Products.Add(product);
        context.Carts.Update(cart);
        context.SaveChanges();
        return cart;
    }
    public Cart RemoveProduct(ClaimsPrincipal user, string productId)
    {
        var userId = GetUserId(user);
        var cart = context.Carts.Include(c => c.Products).FirstOrDefault(c => c.UserId == userId);
        if (cart == null)
            cart = Create(userId);
        var product = cart.Products.FirstOrDefault(c => c.Id==productId);
        if (product!=null)
        {
            cart.Products.Remove(product);
        }
        context.Carts.Update(cart);
        context.SaveChanges();
        return cart;
    }
    public Cart GetCart(ClaimsPrincipal user)
    {
        var userId = GetUserId(user);
        var cart = context.Carts.Include(c => c.Products).FirstOrDefault(c => c.UserId == userId);
        if (cart == null)
            cart = Create(userId);
        return cart;
    }

}
