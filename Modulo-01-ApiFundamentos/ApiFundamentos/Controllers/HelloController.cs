using ApiFundamentos.DTOs;
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

    [HttpGet("{name}")] // -> com parâmetros
    public IActionResult GetName(string name)

    {
        var response = new
        {
            message = $"Hello, {name}!"
        };
        return Ok(response);

    }

    [HttpGet("querytest")] // → com QueryString
    public IActionResult GetWithQueryTest([FromQuery] string? Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            return Ok(new { message = "Nenhum nome foi encontrado" });
        }
        return Ok(new { message = $"Olá {Name}, este é um teste de QueryString" });
    }
    
[HttpPost("create")]
public IActionResult CreateUser([FromBody] UserDto user)
{
    if (string.IsNullOrWhiteSpace(user.Name))
        return BadRequest(new { error = "O campo 'Name' é obrigatório." });

    return Created($"/api/hello/{user.Name}", new
    {
        message = $"Usuário {user.Name} com {user.Age} anos criado com sucesso!"
    });
}


}