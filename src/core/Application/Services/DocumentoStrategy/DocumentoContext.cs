namespace PureAbstraction.Application.Services.DocumentoStrategy;

public class DocumentoContext(
    IEnumerable<IFornecedorStrategy> documentoStrategies)
        : IDocumentoContext
{
    public async Task<string> SolicitarDocumentoAsync(Documento documento)
    {
        // Regras de Negocios Comuns

        var strategy = ObterStrategy(documento);
        var mensagem = await strategy.ObterDocumentoForcedorAsync(documento);

        // Regras de Negocios Comuns

        return mensagem;
    }

    private IFornecedorStrategy ObterStrategy(Documento documento) =>
        documentoStrategies.FirstOrDefault(
            s => s.TipoDocumentos.Contains(documento.TipoDocumento)) ??
                throw new NotImplementedException();
}
