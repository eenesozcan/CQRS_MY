using CQRS_MY.CQRS.Queries.StudentQueries;
using CQRS_MY.CQRS.Results.StudentResult;
using CQRS_MY.DAL.Context;

namespace CQRS_MY.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;
        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public GetStudentByIDQueryResult Handle(int id)
        {
            var values = _context.Students.Find(id);
            return new GetStudentByIDQueryResult
            {
                City = values.City,
                LessonAverage = values.LessonAverage,
                Name = values.Name,
                StudentID = values.StudentID,
                Surname = values.Surname
            };
        }
    }
}
