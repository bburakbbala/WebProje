using Clinic.DataAccess.Data;
using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DataAccess.Repository
{
    public class HospitalRepository : RepositoryAsync<Hospital>, IHospitalRepository
    {
        private readonly ApplicationDbContext _db;
        public HospitalRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Hospital hospital)
        {
            var objFromDb = _db.Hospitals.FirstOrDefault(h => h.Id == hospital.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = hospital.Name;
                _db.SaveChanges();
            }
        }
    }
}
