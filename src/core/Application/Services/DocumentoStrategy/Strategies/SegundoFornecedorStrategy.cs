namespace Application.Services.DocumentoStrategy.Strategies;

public class SegundoFornecedorStrategy
    : IDocumentoStrategy
{
    public List<TipoDocumento> TipoDocumentos =>
        [
            TipoDocumento.CertidaoCasamento
        ];

    public Task<string> ObterDocumentoForcedorAsync(Documento documento)
    {
        throw new NotImplementedException();
    }
}
