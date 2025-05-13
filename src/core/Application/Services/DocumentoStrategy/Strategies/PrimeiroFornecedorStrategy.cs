using Application.Adapters;

namespace Application.Services.DocumentoStrategy.Strategies;

public class PrimeiroFornecedorStrategy(IPrimeiroFornecedor primeiroFornecedor)
    : IDocumentoStrategy
{
    public List<TipoDocumento> TipoDocumentos =>
    [
        TipoDocumento.CertidaoNascimento
    ];

    public async Task<string> ObterDocumentoForcedorAsync(Documento documento)
    {
        // Regras comuns entre o fornecedor
        var mensagemFornecedor = await primeiroFornecedor.SolicitarDocumentoAsync(documento);
        return $"Solicitar {documento.TipoDocumento} no fornecedor {mensagemFornecedor}.";
    }
}
