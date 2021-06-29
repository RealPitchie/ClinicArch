using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.PatientFeatures.Commands;
using Application.Features.PatientFeatures.Queries;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers.v1
{   
    [ApiVersion("1.0")] 
    [Route("[controller]/[action]")]
    public class PatientsController : BaseApiController
    {   
        private readonly DatabaseContext _context;
        private readonly IDictionaryService<TNM> _tnmService;
        public PatientsController(DatabaseContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Creates a New Patient.
        /// </summary> 
        ///<param name="patient"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create( [FromBody]Patient patient/*CreatePatientCommand command*/)
        {
            patient.Id = Guid.NewGuid().ToString();
            await _context.AddAsync(patient);
            await _context.SaveChangesAsync();
            return Ok(patient);
            //return Ok(await Mediator.Send(command));
        }
        /// <summary>
        /// Gets all Patients.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patients = await _context.Patients.ToArrayAsync(); 
            foreach (var item in patients)
            {
                item.Age = DateTime.Now.Year - item.BirthDate.Year;
            }
            return Ok(patients);
            //return Ok(await Mediator.Send(new GetAllPatientsQuery()));
        }
        /// <summary>
        /// Gets Patient Entity by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var patient = await _context.Patients.FirstAsync(p => p.Id == id);
            patient.MenStats = patient.Gender == "male"? _context.MenStats.First(s => s.PatientId == patient.Id) : null;
            patient.WomenStats = patient.Gender == "female"? _context.WomenStats.First(s => s.PatientId == patient.Id) : null;

            return Ok(patient);
        }
        /// <summary>
        /// Deletes Patient Entity based on Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await Mediator.Send(new DeletePatientByIdCommand { Id = id }));
        }
        /// <summary>
        /// Updates the Patient Entity based on Id.   
        /// </summary>
        /// <param name="id"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("[action]")]
        public async Task<IActionResult> Update(string id, UpdatePatientCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
        [HttpGet]
        public async Task<IEnumerable<TNM>> GetTNMs()
        {
            var tnms = await _tnmService.Get();

            return tnms;
        }
    }
}