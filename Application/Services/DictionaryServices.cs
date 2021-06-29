using System.Collections.Generic;
using System.Threading.Tasks; 
using Application.Interfaces;  
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;
using System.Text.Json;
using Domain.Entities;

namespace BlazorPatients.Data.Services
{
    public class TNMService : IDictionaryService<TNM>
    {
        private readonly DatabaseContext _storageContext; 
        public List<string> PatientNames { get; set; } = new List<string>();
        public TNMService(DatabaseContext storageContext)
        {
            _storageContext = storageContext; 
        }

        public async Task<List<TNM>> Get()
        {
            return await _storageContext.TNM.ToListAsync();
        }
        public async Task<string[]> GetNames()
        {
            var names = await (from tnm in _storageContext.TNM select tnm.ShortNameOfTopography).ToArrayAsync();
            
            return names;
        }

        public async Task<TNM> Get(string shortName)
        {
            return await _storageContext.TNM.Where(tnm => tnm.ShortNameOfTopography == shortName).FirstAsync();
        }
        public async Task ToJson()
        { 
            var data = await _storageContext.TNM.Select(x => x.Icdotopography).Distinct().ToListAsync(); 
            using FileStream createStream = File.Create("wwwroot/diagnoses.json");
                await JsonSerializer.SerializeAsync(createStream, data);
        }
        public async Task<List<TNM>> GetFromJson()
        {
            using FileStream openStream = File.OpenRead("wwwroot/tnm.json");
            var data = await JsonSerializer.DeserializeAsync<List<TNM>>(openStream);

            return data;
        }
        public async Task<string[]> GetDiagsFromJson()
        {
            using FileStream openStream = File.OpenRead("wwwroot/diagnoses.json");
            var data = await JsonSerializer.DeserializeAsync<string[]>(openStream);

            return data;
        } 
        public async Task<string[]> GetDDiagsFromJson()
        {
            using FileStream openStream = File.OpenRead("wwwroot/d-diags.json");
            var data = (from dd in await JsonSerializer.DeserializeAsync<List<DDiag>>(openStream) select dd.Name + " " + dd.Description);

            return data.ToArray();
        } 
    }
}