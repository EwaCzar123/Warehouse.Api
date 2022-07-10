using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Models;

namespace Warehouse.Api.Controllers;


[ApiController]
[Route("[controller]")]
public class PalletsController: ControllerBase
{
    private static readonly Pallet pallet = new();
     

    [HttpGet]
    public ActionResult<Pallet> Get()
    {
        return Ok(pallet);
    }    
}