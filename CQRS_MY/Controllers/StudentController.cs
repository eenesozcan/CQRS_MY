using CQRS_MY.CQRS.Commands.StudentCommands;
using CQRS_MY.CQRS.Handlers.StudentHandlers;
using CQRS_MY.CQRS.Queries.StudentQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MY.Controllers
{
    public class StudentController : Controller
    {
        private readonly GetStudentQueryHandler _studentQueryHandler;
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetStudentByIDQueryHandler _studentByIDQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;


        public StudentController(GetStudentQueryHandler studentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, GetStudentByIDQueryHandler studentByIDQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler)
        {
            _studentQueryHandler = studentQueryHandler;
            _createStudentCommandHandler = createStudentCommandHandler;
            _studentByIDQueryHandler = studentByIDQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _studentQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }


        public IActionResult GetStudent(int id)
        {
            var values = _studentByIDQueryHandler.Handle(id);
            return View(values);

        }

        public IActionResult RemoveStudent(int id)
        {
            _removeStudentCommandHandler.Handle(id);
            return RedirectToAction("Index");
        }
    }
}
