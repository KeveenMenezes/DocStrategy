namespace PureAbstraction.Domain.Entities.Documentos;

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

    [Required]
    public DateTime DataCasamento { get; set; }
}