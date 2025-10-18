using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace  ApiFundamentos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var response = new
        {
            message = "Hello, FullStack Journey!"
        };

        return Ok(response);
    }

    [HttpGet("{name}")]
    public IActionResult GetName(string name)
    
    {
    var response = new
    {
        message = $"Hello, {name}!"
    };
    return Ok(response);
        
    }
}