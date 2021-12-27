using Clinic.Models;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface ILastnameRepository : IRepositoryAsync<Lastname>
    {
        void Update(Lastname lastname);
    }
}