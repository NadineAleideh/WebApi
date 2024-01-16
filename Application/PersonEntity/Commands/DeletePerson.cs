using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PersonEntity.Commands
{
    public class DeletePerson: IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
