using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using az_api.Models;
using az_api.DataAccess;
using System.Data;

namespace az_api.Controllers;

[ApiController]
[Route("api/")]
public class SyainController : AzController
{
    private readonly SyainDataAccess _syainDataAccess;
    public SyainController(AzDbContext context, SyainDataAccess syainDataAccess) : base(context)
    {
        _syainDataAccess = syainDataAccess;
    }    

    [HttpGet("syain/{id}")]
    [HttpGet("syain/{id}/ef")]
    public async Task<IActionResult> GetSyainByEF(long id)
    {
        var result = await _context.t_syains
            .Where(x => x.id == id)
            .Select(x => new
            {
                x.syain_cd,
                x.syain_name
            })
            .FirstOrDefaultAsync();

        return Ok(result);
    }

    [HttpGet("syain/{id}/sql")]
    public async Task<IActionResult> GetSyainBySql(long id)
    {
        DataTable dataTable = await _syainDataAccess.GetSyainAsync(id);
        var result = dataTable.AsEnumerable()
            .Select(row => new
            {
                syain_cd = row["syain_cd"],
                syain_name = row["syain_name"]
            })
            .FirstOrDefault();

        return Ok(result);
    }    
}
