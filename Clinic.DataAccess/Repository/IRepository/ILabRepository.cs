using Clinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface ILabRepository : IRepositoryAsync<Lab>
    {
        void Update(Lab lab);
    }
}
