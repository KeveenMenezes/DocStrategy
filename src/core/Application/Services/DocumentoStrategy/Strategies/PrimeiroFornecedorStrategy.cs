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
        var mensagemFornecedor = primeiroFornecedor.SolicitarDocumentoAsync(documento);
        return $"Solicitar {documento.TipoDocumento} no fornecedor {mensagemFornecedor}.";
    }
}
