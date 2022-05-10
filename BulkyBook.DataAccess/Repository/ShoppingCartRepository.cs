using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly Data.ApplicationDbContext _db;
        public ShoppingCartRepository(Data.ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public int DecrementCount(ShoppingCart shoppingCard, int count)
        {
            shoppingCard.Count -= count;
            return shoppingCard.Count;
        }

        public int IncrementCount(ShoppingCart shoppingCard, int count)
        {
            shoppingCard.Count += count;
            return shoppingCard.Count;
        }
    }
}
