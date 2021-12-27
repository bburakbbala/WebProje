using Clinic.DataAccess.Data;
using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using System.Linq;

namespace Clinic.DataAccess.Repository
{
    public class AddressRepository : RepositoryAsync<Address>, IAddressRepository
    {
        private readonly ApplicationDbContext _db;
        public AddressRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Address address)
        {
            var objFromDb = _db.Addresses.FirstOrDefault(d => d.Id == address.Id);
            if (objFromDb != null)
            {
                objFromDb.AddressDetail = address.AddressDetail;
            }
        }
    }
}
