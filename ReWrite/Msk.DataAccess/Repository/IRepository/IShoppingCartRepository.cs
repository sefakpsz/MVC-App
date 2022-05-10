using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace ReWrite.Msk.DataAccess.Repository.IRepository
{
    public class IShoppingCartRepository : Repository<ShoppingCart>, IRepository<ShoppingCart>
    {
        private readonly ApplicationDbContext _db;
        public IShoppingCartRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }
    }
}
