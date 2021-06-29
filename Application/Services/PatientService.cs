using System;
using System.Collections.Generic;
using System.Threading.Tasks; 
using Application.Interfaces; 
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain.Entities;

namespace BlazorPatients.Data.Services
{
    public class PatientService : IStorageService<Patient>
    {
        private readonly DatabaseContext _storageContext; 
        public List<string> PatientNames { get; set; } = new List<string>();
        public PatientService(DatabaseContext storageContext)
        {
            _storageContext = storageContext; 
        }
        public async Task<Patient> CreatePatient(Patient patient)
        {
            patient.Id = Guid.NewGuid().ToString();

            await _storageContext.AddAsync(patient).ConfigureAwait(false);

            return patient;
        }
        public async Task<Man> AddMenStats(Man menStats)
        {
            var patient = await _storageContext.Patients.FirstAsync(p => p.Id == menStats.PatientId).ConfigureAwait(false);
            patient.MenStats = menStats;
            _storageContext.Update(patient);
            await _storageContext.MenStats.AddAsync(menStats).ConfigureAwait(false);
            await _storageContext.SaveChangesAsync().ConfigureAwait(false);

            return menStats;

        }
        public async Task<Patient> Add(Patient patient)
        {
            
            patient.MenStats.Id = Guid.NewGuid().ToString();
            patient.WomenStats.Id = Guid.NewGuid().ToString();
            patient.MenStats.PatientId = patient.MenStats == null? null : patient.Id;
            patient.WomenStats.PatientId = patient.WomenStats == null? null : patient.Id;
            
            _storageContext.Patients.Add(patient);
            await _storageContext.SaveChangesAsync();
            return patient;
        }

        public async Task<Patient> Delete(string id)
        {
            var unit = await _storageContext.Patients.FindAsync(id);
            
            _storageContext.Patients.Remove(unit);
            await _storageContext.SaveChangesAsync();
            return unit;
        }

        public async Task<List<Patient>> Get()
        {
            return await _storageContext.Patients.ToListAsync(); 
        }

        public async Task<Patient> Get(string id)
        {
            var Patient = await _storageContext.Patients.FindAsync(id);
            if(Patient.Gender == "Male")
            {
                Patient.MenStats = _storageContext.MenStats.First(s => s.PatientId == id);
                Patient.MenStats.TNM = _storageContext.TNM.First(t => t.PatientId == Patient.Id);
            }else{
                Patient.WomenStats = _storageContext.WomenStats.First(s => s.PatientId == id);
                Patient.WomenStats.TNM = _storageContext.TNM.First(t => t.PatientId == Patient.Id);
            }
            return Patient;
        }

        public Task<Patient> GetAll(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Patient> Update(Patient T)
        {
            _storageContext.Entry(T).State = EntityState.Modified;
            await _storageContext.SaveChangesAsync();
            return T;
        }

        Task<List<Patient>> IStorageService<Patient>.GetAll(string id)
        {
            throw new System.NotImplementedException();
        } 
    }
}