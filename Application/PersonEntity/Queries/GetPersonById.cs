using Domain.Entities;
using MediatR;


namespace Application.PersonEntity.Queries
{
    public class GetPersonById : IRequest<Person>
    {
        public int Id { get; set; }
    }
}
