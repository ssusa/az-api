using Microsoft.AspNetCore.Mvc;

namespace az_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AzController : ControllerBase
{
    private readonly ILogger<AzController> _logger;

    public AzController(ILogger<AzController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("AzController Get called");
        return Ok(new { message = "Hello from AzController" });
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        _logger.LogInformation($"AzController GetById called with id: {id}");
        return Ok(new { id = id, message = $"Item with id {id}" });
    }

    [HttpPost]
    public IActionResult Post([FromBody] dynamic request)
    {
        _logger.LogInformation("AzController Post called");
        return Ok(new { success = true, message = "Data received" });
    }
}
