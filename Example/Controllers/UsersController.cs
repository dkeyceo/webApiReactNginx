using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers;

[Route("/api/users")]
[ApiController]
public class UsersController: ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new []
        {
            new { Name = "Oleg"},
            new { Name = "Dima"},
            new{ Name = "Oksana"},
        };
        return Ok (users);
    }
}