using Microsoft.AspNetCore.Mvc;

namespace PureAbstraction.WebApi.Controllers;

[ApiController]
[Route("api/v{v:apiVersion}/[controller]")]
[ApiConventionType(typeof(DefaultApiConventions))]
public abstract class MainController : ControllerBase
{
    // Other controller methods and properties
}
