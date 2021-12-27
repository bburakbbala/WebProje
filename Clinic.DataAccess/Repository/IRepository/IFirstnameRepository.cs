using Clinic.Models;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface IFirstnameRepository : IRepositoryAsync<Firstname>
    {
        void Update(Firstname firstname);
    }
}