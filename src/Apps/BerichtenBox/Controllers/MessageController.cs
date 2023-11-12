using BerichtenBox.Infra.Models;
using BerichtenBox.Infra.Services;
using BerichtenBox.Infra.Validation;
using Microsoft.AspNetCore.Mvc;

namespace BerichtenBox.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IMessageStore _messageStore;
    private readonly ITslMessageValidator _messageValidator;

    public MessageController(IMessageStore messageStore, ITslMessageValidator messageValidator)
    {
        _messageValidator = messageValidator;
        _messageStore = messageStore;
    }
    // POST api/<MessageController>
    [HttpPost]
    public IActionResult Post([FromBody] TslMessage message)
    {
        if (_messageValidator.Validate(message))
        {
            _messageStore.Add(message);
            return Ok();
        }

        return BadRequest("TslMessage is not valid.");
    }
}