namespace DocStrategy.WebApi.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiConventionType(typeof(DefaultApiConventions))]
public abstract class MainController : ControllerBase
{
    // Outros metodos ou propriedades comuns
}
