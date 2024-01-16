using Application.Abstractions;
using Application.PersonEntity.Commands;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonEntity.CommandHandlers
{
    public class DeletePersonHandler : IRequestHandler<DeletePerson, Unit>
    {
        private readonly IPersonRepository _personRepository;


        public DeletePersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public async Task<Unit> Handle(DeletePerson request, CancellationToken cancellationToken)
        {
            var existingPerson = await _personRepository.GetPersonById(request.Id);

            _personRepository.DeletePerson(existingPerson.Id);


            return Unit.Value;
        }
    }
}
