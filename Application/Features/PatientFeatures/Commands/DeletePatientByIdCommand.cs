using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.PatientFeatures.Commands
{
    public class DeletePatientByIdCommand : IRequest<string>
    {
        public string Id { get; set; }
        public class DeletePatientByIdCommandHandler : IRequestHandler<DeletePatientByIdCommand, string>
        {
            private readonly IDatabaseContext _context;
            public DeletePatientByIdCommandHandler(IDatabaseContext context)
            {
                _context = context;
            }
            public async Task<string> Handle(DeletePatientByIdCommand command, CancellationToken cancellationToken)
            {
                var patient = await _context.Patients.Where(a => a.Id == command.Id).FirstOrDefaultAsync();
                if (patient == null) return default;
                _context.Patients.Remove(patient);
                await _context.SaveChanges();
                return patient.Id;
            }
        }
    }
}