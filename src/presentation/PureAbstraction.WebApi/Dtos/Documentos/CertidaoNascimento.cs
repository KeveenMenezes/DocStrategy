namespace PureAbstraction.WebApi.Dtos.Documentos;

public class CertidaoNascimento : Documento
{
    [Required]
    public required string Nome { get; set; }

    [Required]
    public required string NomeMae { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }
}
