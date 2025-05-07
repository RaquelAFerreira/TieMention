using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using TieMention.Application.Mentions.Commands;
using TieMention.Application.Mentions.Queries;

namespace TieMention.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MentionController : ControllerBase
{
    private readonly IMediator _mediator;
    public MentionController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await _mediator.Send(new GetMentionQuery()));

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateMentionCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(Get), new { id }, id);
    }
}