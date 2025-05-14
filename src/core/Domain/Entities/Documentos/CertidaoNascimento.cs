namespace PureAbstraction.Domain.Entities.Documentos;

public class CertidaoNascimento
    : Documento
{
    public CertidaoNascimento()
    {
        TipoDocumento = TipoDocumento.CertidaoNascimento;
    }

    [Required]
    public string Nome { get; set; }

    [Required]
    public string NomeMae { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }
}
