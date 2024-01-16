
using Application.Abstractions;
using Application.PersonEntity.Queries;
using Domain.Entities;
using MediatR;

namespace Application.PersonEntity.QueryHandlers
{

    public class GetPersonByIdHandler : IRequestHandler<GetPersonById, Person>
    {
        private readonly IPersonRepository _personRepository;

        public GetPersonByIdHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person> Handle(GetPersonById request, CancellationToken cancellationToken)
        {
            return await _personRepository.GetPersonById(request.Id);
        }

    }
}
