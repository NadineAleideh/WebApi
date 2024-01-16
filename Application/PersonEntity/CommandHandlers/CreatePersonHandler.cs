
using Application.Abstractions;
using Application.PersonEntity.Commands;
using Domain.Entities;
using MediatR;



namespace Application.PersonEntity.CommandHandlers
{
    public class CreatePersonHandler : IRequestHandler<CreatePerson, Person>
    {
        private readonly IPersonRepository _personRepository;


        public CreatePersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public async Task<Person> Handle(CreatePerson request, CancellationToken cancellationToken)
        {
            var person = new Person
            {
                Name = request.Name,
                Email = request.Email
            };

            return await _personRepository.AddPerson(person);
        }
    }
}
