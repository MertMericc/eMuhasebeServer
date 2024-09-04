using eMuhasebeServer.Application.Features.Companies.CreateCompany;
using eMuhasebeServer.Application.Features.Companies.DeleteCompanyById;
using eMuhasebeServer.Application.Features.Companies.GetAllCompanies;
using eMuhasebeServer.Application.Features.Companies.UpdateCompany;
using eMuhasebeServer.Application.Features.MigrateAllCompanies;
using eMuhasebeServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eMuhasebeServer.WebAPI.Controllers;

[AllowAnonymous]
public sealed class CompaniesController : ApiController
{
    public CompaniesController(IMediator mediator):base(mediator)
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCompaniesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCompanyCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }


    [HttpPost]
    public async Task<IActionResult> Delete(DeleteCompanyByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> MigrateAll(MigrateAllCompaniesCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}