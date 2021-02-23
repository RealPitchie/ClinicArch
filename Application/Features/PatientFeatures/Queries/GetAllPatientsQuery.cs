using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.PatientFeatures.Queries
{
    public class GetAllPatientsQuery : IRequest<IEnumerable<Patient>>
    {

        public class GetAllPatientsQueryHandler : IRequestHandler<GetAllPatientsQuery, IEnumerable<Patient>>
        {
            private readonly IDatabaseContext _context;
            public GetAllPatientsQueryHandler(IDatabaseContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Patient>> Handle(GetAllPatientsQuery query, CancellationToken cancellationToken)
            {
                var patients = await _context.Patients.ToListAsync();
                if (patients == null)
                {
                    return null;
                }
                return patients.AsReadOnly();
            }
        }
    }
}