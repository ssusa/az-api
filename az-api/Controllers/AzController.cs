using Microsoft.AspNetCore.Mvc;
using az_api.Models;
using az_api.DataAccess;

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

    //protected readonly AzDbContext _context;
    //protected readonly SyainDataAccess _syainDataAccess;  // 使用する場合、SyainController内で初期化

    // public AzController(AzDbContext context, SyainDataAccess syainDataAccess)
    // {
    //     _context = context;
    //     _syainDataAccess = syainDataAccess;
    // }
}
