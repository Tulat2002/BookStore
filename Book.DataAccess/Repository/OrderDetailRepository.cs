using System.Linq.Expressions;
using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using Book.Models;

namespace Book.DataAccess.Repository;

public class OrderDetailRepository :  Repository<OrderDetail>, IOrderDetailRepository
{
    private ApplicationDbContext _db;
    public OrderDetailRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(OrderDetail obj)
    {
        _db.OrderDetails.Update(obj);
    }
    
}