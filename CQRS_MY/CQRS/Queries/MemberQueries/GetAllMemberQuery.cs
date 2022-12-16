using CQRS_MY.CQRS.Results.MemberResult;
using MediatR;
using System.Collections.Generic;

namespace CQRS_MY.CQRS.Queries.MemberQueries
{
    public class GetAllMemberQuery : IRequest<List<GetAllMemberResult>>
    {

    }
}
