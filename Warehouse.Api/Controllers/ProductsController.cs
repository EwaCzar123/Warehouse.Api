using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Models;

namespace Warehouse.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController: ControllerBase
{
    private static readonly List<Product> products = new()
    {
        new Product
        {
            Id = 1, Code = "1111"
        },
        new Product
        {
            Id = 2, Code = "2222"
        }
    };

    [HttpGet("{code}")]
    public ActionResult<Product> Get(string code)
    {
        return Ok(products.FirstOrDefault(p => p.Code == code));
    }

    [HttpPut("{code}")]
    public ActionResult<Product> AddProduct(string code)
    {
        products.Add(new Product{Id = 3, Code = code});
        return Ok(products);
    }

    [HttpGet]
    public ActionResult<Product> Get()
    {
        return Ok(products);
    }
}