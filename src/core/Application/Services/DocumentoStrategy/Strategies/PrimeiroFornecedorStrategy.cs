using Application.Adapters;

namespace Application.Services.DocumentoStrategy.Strategies;

public class PrimeiroFornecedorStrategy(
    IPrimeiroFornecedorAdapter primeiroFornecedorAdapter)
    : IDocumentoStrategy
{
    public List<TipoDocumento> TipoDocumentos =>
    [
        TipoDocumento.CertidaoNascimento
    ];

    public async Task<string> ObterDocumentoForcedorAsync(Documento documento)
    {
        // Regras comuns entre o fornecedor
        var mensagemFornecedor = await primeiroFornecedorAdapter.SolicitarDocumentoAsync(documento);
        return $"Solicitar {documento.TipoDocumento} no fornecedor {mensagemFornecedor}.";
    }
}
