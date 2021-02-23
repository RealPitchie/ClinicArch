using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.PatientFeatures.Commands
{
	public class UpdatePatientCommand : IRequest<string>
	{
		public string Id { get; set; }
		public string FullName { get; set; }

		public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommand, string>
		{
			private readonly IDatabaseContext _context;
			public UpdatePatientCommandHandler(IDatabaseContext context)
			{
				_context = context;
			}
			public async Task<string> Handle(UpdatePatientCommand command, CancellationToken cancellationToken)
			{
				var patient = _context.Patients.Where(a => a.Id == command.Id).FirstOrDefault();

				if (patient == null)
				{
						return default;
				}
				else
				{
						patient.FullName = command.FullName;

						await _context.SaveChanges();
						return patient.Id;
				}
			}
		}
	}
}
