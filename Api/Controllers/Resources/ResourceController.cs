using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Resources;

[ApiController]
[Route("/api/resources")]
public class ResourceController : ControllerBase
{
    [HttpGet]
    public IActionResult HelloAsync()
    {
        return Ok("Hello World!");
    }
    
    [HttpGet("public")]
    public IActionResult HelloPublicAsync()
    {
        return Ok("Hello World!");
    }
}