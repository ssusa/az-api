using Microsoft.AspNetCore.Mvc;
using az_api.Models;

namespace az_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AzController : ControllerBase
{
    protected readonly AzDbContext _context;
    public AzController(AzDbContext context)
    {
        _context = context;
    }
}
