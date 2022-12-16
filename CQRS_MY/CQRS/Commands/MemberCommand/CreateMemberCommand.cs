using MediatR;

namespace CQRS_MY.CQRS.Commands.MemberCommand
{
    public class CreateMemberCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
