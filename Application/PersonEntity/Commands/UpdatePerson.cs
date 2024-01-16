using Domain.Entities;
using MediatR;


namespace Application.PersonEntity.Commands
{
    public class UpdatePerson : IRequest<Person>
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
