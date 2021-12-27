﻿using System;
using System.Threading.Tasks;

namespace Clinic.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISP_Call SP_Call { get; }
        Task SaveAsync();
        IAddressRepository Address { get; }
        IBloodTypeRepository BloodType { get; }
        ICityRepository City { get; }
        ICountryOrRegionRepository CountryOrRegion { get; }
        IDepartmentRepository Department { get; }
        IDoctorRepository Doctor { get; }
        IDoctorTreatmentRepository DoctorTreatment { get; }
        IFirstnameRepository Firstname { get; }
        IHospitalRepository Hospital { get; }
        IHospitalDepartmentRepository HospitalDepartment { get; }
        IHospitalLabRepository HospitalLab { get; }
        IHospitalVisitRepository HospitalVisit { get; }
        ILabRepository Lab { get; }
        ILabMachineRepository LabMachine { get; }
        ILastnameRepository Lastname { get; }
        IMedicineRepository Medicine { get; }
        IMedicineCategoryRepository MedicineCategory { get; }
        IMedicineUsageRepository MedicineUsage { get; }
        IPatientRepository Patient { get; }
        IPatientMedicineRepository PatientMedicine { get; }
        IPrescriptionRepository Prescription { get; }
        IPrescriptionMedicineRepository PrescriptionMedicine { get; }
        IProfessionRepository Profession { get; }
        IProvinceRepository Province { get; }
        ITestRepository Test { get; }
        ITestResultRepository TestResult { get; }
        ITestResultTestRepository TestResultTest { get; }
        ITreatmentRepository Treatment { get; }
        ITreatmentMedicineRepository TreatmentMedicine { get; }

    }
}
