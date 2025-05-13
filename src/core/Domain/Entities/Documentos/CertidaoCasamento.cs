namespace Domain.Entities.Documentos;

public class CertidaoCasamento
    : Documento
{
    public CertidaoCasamento()
    {
        TipoDocumento = TipoDocumento.CertidaoCasamento;
    }

    [Required]
    public string Nome { get; set; }

    [Required]
    public string NomeConjuge { get; set; }

    public required DateTime DataCasamento { get; set; }
}