using Clinic.DataAccess.Data;
using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using System.Linq;

namespace Clinic.DataAccess.Repository
{
    public class LastnameRepository : RepositoryAsync<Lastname>, ILastnameRepository
    {
        private readonly ApplicationDbContext _db;
        public LastnameRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Lastname lastname)
        {
        }
    }
}
