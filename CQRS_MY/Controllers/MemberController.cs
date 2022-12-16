using CQRS_MY.CQRS.Commands.MemberCommand;
using CQRS_MY.CQRS.Queries.MemberQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS_MY.Controllers
{
    public class MemberController : Controller
    {

        private readonly IMediator _mediator;

        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllMemberQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMember(CreateMemberCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

    }
}
