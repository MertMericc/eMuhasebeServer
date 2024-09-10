﻿using MediatR;
using TS.Result;

namespace eMuhasebeServer.Application.Features.Users.CreateUser;
public sealed record CreateUserCommand(
        string FirtName,
        string LastName,
        string UserName,
        string Email,
        string Password,
        List<Guid> CompanyIds) : IRequest<Result<string>>;


