using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using az_api.Models;

namespace az_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SyainController : AzController
{

    public SyainController(AzDbContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<t_syozoku>>> GetSyozoku()
    {
        return await _context.t_syozokus.Include(x => x.t_syain).Include(x => x.t_busyo).ToListAsync();
    }
}
