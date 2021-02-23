using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.PatientFeatures.Queries
{
    public class GetPatientByIdQuery : IRequest<Patient>
    {
        public string Id { get; set; }
        public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, Patient>
        {
            private readonly IDatabaseContext _context;
            public GetPatientByIdQueryHandler(IDatabaseContext context)
            {
                _context = context;
            }
            public async Task<Patient> Handle(GetPatientByIdQuery query, CancellationToken cancellationToken)
            {
                var patient = await _context.Patients.Where(a => a.Id == query.Id).FirstOrDefaultAsync();
                if (patient == null) return null;
                return patient;
            }
        }
    }
}