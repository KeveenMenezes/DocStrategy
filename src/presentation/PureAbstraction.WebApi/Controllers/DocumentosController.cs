namespace PureAbstraction.WebApi.Controllers;

public class DocumentosController(
    IDocumentoContext documentoContext)
    : MainController
{
    [HttpPost("certidao-casamento")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SolicitarDocumento(CertidaoCasamentoDto certidaoCasamentoDto)
    {
        try
        {
            var retorno = await documentoContext.SolicitarDocumentoAsync(
                certidaoCasamentoDto.MapearDocumentoDomain());

            return Ok(retorno);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost("certidao-nascimento")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SolicitarDocumento(CertidaoNascimentoDto certidaoNascimentoDto)
    {
        try
        {
            var retorno = await documentoContext.SolicitarDocumentoAsync(
                certidaoNascimentoDto.MapearDocumentoDomain());

            return Ok(retorno);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
