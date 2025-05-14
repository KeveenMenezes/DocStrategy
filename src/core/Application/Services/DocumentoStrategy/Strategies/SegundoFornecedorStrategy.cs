using Domain.Interfaces.Adapters;

namespace Application.Services.DocumentoStrategy.Strategies;

public class SegundoFornecedorStrategy(
    ISegundoFornecedorAdapter segundoFornecedorAdapter)
    : IDocumentoStrategy
{
    public List<TipoDocumento> TipoDocumentos =>
        [
            TipoDocumento.CertidaoCasamento
        ];

    public async Task<string> ObterDocumentoForcedorAsync(Documento documento)
    {
        // Regras comuns entre o fornecedor

        var mensagemFornecedor = await segundoFornecedorAdapter.SolicitarDocumentoAsync(documento);
        return $"Solicitar {documento.TipoDocumento} no fornecedor {mensagemFornecedor}.";
    }
}
