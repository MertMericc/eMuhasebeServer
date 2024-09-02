using eMuhasebeServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eMuhasebeServer.Application.Features.Users.GetAllUsersQuery
{
    public sealed record GetAllUsersQuery():IRequest<Result<List<AppUser>>>;
}
