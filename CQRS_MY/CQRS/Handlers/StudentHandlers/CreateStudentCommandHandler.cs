using CQRS_MY.CQRS.Commands.StudentCommands;
using CQRS_MY.DAL.Context;
using CQRS_MY.DAL.Entities;

namespace CQRS_MY.CQRS.Handlers.StudentHandlers
{

    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;
        
        public CreateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.studentName,
                Surname = command.studentSurname,
                Department = command.studentDepartment
            });
            _context.SaveChanges();
        }
    }
}
