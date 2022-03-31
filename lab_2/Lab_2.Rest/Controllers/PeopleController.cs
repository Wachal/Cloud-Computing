using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Lab_2.Rest.Context;

namespace ExampleWebApp.Rest.Controllers{

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly AzureDbEntities context;

    public PeopleController(AzureDbEntities context)
    {
        this.context = context;
    }

    public async Task<ActionResult> Get()
    {
        return Ok(await context.People.ToListAsync());
    }
}
}