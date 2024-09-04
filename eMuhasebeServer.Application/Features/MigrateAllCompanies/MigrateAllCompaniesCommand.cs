using MediatR;
using TS.Result;

namespace eMuhasebeServer.Application.Features.MigrateAllCompanies;
public sealed class MigrateAllCompaniesCommand():IRequest<Result<string>>;



