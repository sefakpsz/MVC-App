
namespace ReWrite.Msk.DataAccess.Repository.IRepository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        readonly private ApplicaitonDbContext _db;
        public ShoppingCartRepository(ApplicaitonDbContext db)
            :base(db)
        {
            _db = db;
        }
    }
}
