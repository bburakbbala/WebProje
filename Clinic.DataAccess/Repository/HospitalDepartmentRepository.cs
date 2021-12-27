using Clinic.DataAccess.Data;
using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;

namespace Clinic.DataAccess.Repository
{
    public class HospitalDepartmentRepository : RepositoryAsync<HospitalDepartmant>, IHospitalDepartmentRepository
    {
        private readonly ApplicationDbContext _db;
        public HospitalDepartmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HospitalDepartmant hospitalDepartmant)
        {

        }
    }
}
