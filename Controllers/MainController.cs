using Microsoft.AspNetCore.Mvc;

namespace dotnet_default.Controllers;

[ApiController]
[Route("/")]
public class MainController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello from DotNet app";
    }
} 