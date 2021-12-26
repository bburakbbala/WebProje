﻿using Clinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface IDepartmentRepository : IRepositoryAsync<Department>
    {
        void Update(Department departmant);
    }
}
