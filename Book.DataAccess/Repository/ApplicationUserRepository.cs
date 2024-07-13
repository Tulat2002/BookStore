using System.Linq.Expressions;
using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using Book.Models;

namespace Book.DataAccess.Repository;

public class ApplicationUserRepository :  Repository<ApplicationUser>, IApplicationUserRepository
{
    private ApplicationDbContext _db;
    public ApplicationUserRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    
}