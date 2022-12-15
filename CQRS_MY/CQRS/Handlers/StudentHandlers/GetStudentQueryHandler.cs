using CQRS_MY.CQRS.Results.StudentResult;
using CQRS_MY.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_MY.CQRS.Handlers.StudentHandlers
{
    public class GetStudentQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public List<GetStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x =>
            new GetStudentQueryResult
            {
                StudentID = x.StudentID,
                Name = x.Name,
                Surname = x.Surname,
                City = x.City
            }).ToList();
            return values;
        }
    }
}
