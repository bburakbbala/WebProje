using Clinic.DataAccess.Data;
using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using System.Linq;

namespace Clinic.DataAccess.Repository
{
    public class FirstnameRepository : RepositoryAsync<Firstname>, IFirstnameRepository
    {
        private readonly ApplicationDbContext _db;
        public FirstnameRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Firstname firstname)
        {
        }
    }
}
