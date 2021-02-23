using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.PatientFeatures.Commands
{
    public class CreatePatientCommand : IRequest<string>
    {
        public string FullName { get; set; } 
        public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, string>
        {
            private readonly IDatabaseContext _context;
            public CreatePatientCommandHandler(IDatabaseContext context)
            {
                _context = context;
            }
            public async Task<string> Handle(CreatePatientCommand command, CancellationToken cancellationToken)
            {
                var patient = new Patient(); 
                patient.FullName = command.FullName; 
                _context.Patients.Add(patient);
                await _context.SaveChanges();
                return patient.Id;
            }
        }
    }
}