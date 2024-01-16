using Application.Abstractions;
using Application.PersonEntity.Queries;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonEntity.QueryHandlers
{
    public class GetAllPersonsHandler : IRequestHandler<GetAllPersons, IEnumerable<Person>>
    {
        private readonly IPersonRepository _personRepository;

        public GetAllPersonsHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> Handle(GetAllPersons request, CancellationToken cancellationToken)
        {
            return await _personRepository.GetAll();
        }
    }
}


