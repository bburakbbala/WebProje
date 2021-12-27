using Clinic.Models;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface IAddressRepository : IRepositoryAsync<Address>
    {
        void Update(Address address);
    }
}