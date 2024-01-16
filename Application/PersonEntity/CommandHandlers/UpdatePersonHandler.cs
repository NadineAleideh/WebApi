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
    public class UpdatePersonHandler : IRequestHandler<UpdatePerson, Person>
    {
        private readonly IPersonRepository _personRepository;


        public UpdatePersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person> Handle(UpdatePerson request, CancellationToken cancellationToken)
        {
            var existingPerson = await _personRepository.GetPersonById(request.Id);

            if (existingPerson != null)
            {
                existingPerson.Name = request.Name;
                existingPerson.Email = request.Email;
            }



            return existingPerson;
        }
    }
}
