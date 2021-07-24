using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string firstName, string lastName) : IRequest<PersonModel>;
    
}
