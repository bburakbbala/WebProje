using Clinic.Models;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface IHospitalDepartmentRepository : IRepositoryAsync<HospitalDepartmant>
    {
        void Update(HospitalDepartmant hospitalDepartmant);
    }
}
