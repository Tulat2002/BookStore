using System.Linq.Expressions;
using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using Book.Models;

namespace Book.DataAccess.Repository;

public class ShoppingCartRepository :  Repository<ShoppingCart>, IShoppingCartRepository
{
    private ApplicationDbContext _db;
    public ShoppingCartRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(ShoppingCart obj)
    {
        _db.ShoppingCarts.Update(obj);
    }
    
}