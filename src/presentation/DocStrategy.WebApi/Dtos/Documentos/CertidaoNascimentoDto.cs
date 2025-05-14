namespace DocStrategy.WebApi.Dtos.Documentos;

public class CertidaoNascimentoDto : DocumentoDto
{
    [Required]
    public required string Nome { get; set; }

    [Required]
    public required string NomeMae { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }
}
