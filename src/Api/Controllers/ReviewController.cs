using System.Net;
using Ecommerce.Application.Features.Reviews.Commands.CreateReview;
using Ecommerce.Application.Features.Reviews.Queries.Vms;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ReviewController : ControllerBase
{
    private IMediator _mediator;

    public ReviewController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost(Name = "CreateReview")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<ReviewVm>> CreateReview([FromBody] CreateReviewCommand request)
    {
        return await _mediator.Send(request);
    }

}