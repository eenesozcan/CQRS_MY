using CQRS_MY.CQRS.Commands.MemberCommand;
using CQRS_MY.DAL.Context;
using CQRS_MY.DAL.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_MY.CQRS.Handlers.MemberHandlers
{
    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly ProductContext _context;
        public CreateMemberCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            _context.Members.Add(new Member
            {
                Name = request.Name,
                Surname = request.Surname,
                City = request.City
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
