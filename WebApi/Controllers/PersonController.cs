using Application.PersonEntity.Commands;
using Application.PersonEntity.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAllPersons()
        {
            var query = new GetAllPersons();
            var persons = await _mediator.Send(query);
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var query = new GetPersonById { Id = id };
            var person = await _mediator.Send(query);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult<Person>> CreateProduct([FromBody] CreatePerson command)
        {
            var persontoadd = await _mediator.Send(command);
            return Ok(persontoadd);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Person>> UpdateProduct(int id, [FromBody] UpdatePerson command)
        {
            command.Id = id;
            var personToEdit = await _mediator.Send(command);
            return Ok(personToEdit);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var command = new DeletePerson { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
