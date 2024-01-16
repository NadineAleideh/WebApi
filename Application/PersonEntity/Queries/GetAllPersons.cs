using Domain.Entities;
using MediatR;


namespace Application.PersonEntity.Queries
{
    public class GetAllPersons : IRequest<IEnumerable<Person>>
    {
    }
}
