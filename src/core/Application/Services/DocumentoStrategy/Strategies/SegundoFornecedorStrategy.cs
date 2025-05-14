using PureAbstraction.Domain.Interfaces.Adapters;

namespace PureAbstraction.Application.Services.DocumentoStrategy.Strategies;

public class SegundoFornecedorStrategy(
    ISegundoFornecedorAdapter segundoFornecedorAdapter)
    : IFornecedorStrategy
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
