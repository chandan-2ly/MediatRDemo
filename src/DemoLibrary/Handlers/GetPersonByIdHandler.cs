using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IMediator mediator;

        public GetPersonByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            //calling mediator inside mediator
            var result = await mediator.Send(new GetPersonListQuery());
            return result.FirstOrDefault(x => x.Id == request.id);
        }
    }
}
