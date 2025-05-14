using PureAbstraction.Domain.Interfaces.Adapters;

namespace PureAbstraction.Application.Services.DocumentoStrategy.Strategies;

public class PrimeiroFornecedorStrategy(
    IPrimeiroFornecedorAdapter primeiroFornecedorAdapter)
    : IFornecedorStrategy
{
    public List<TipoDocumento> TipoDocumentos =>
    [
        TipoDocumento.CertidaoNascimento
    ];

    public async Task<string> ObterDocumentoForcedorAsync(Documento documento)
    {
        // Regras comuns entre o fornecedor

        var mensagemFornecedor = await primeiroFornecedorAdapter.SolicitarDocumentoAsync(documento);
        return $"Solicitar {documento.TipoDocumento} no {mensagemFornecedor}.";
    }
}
