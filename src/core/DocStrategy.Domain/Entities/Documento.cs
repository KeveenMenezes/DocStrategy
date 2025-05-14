namespace DocStrategy.Domain.Entities;

public class Documento
    : Entity
{
    [Key]
    public new Guid Id { get; private set; }

    [Required]
    public TipoDocumento TipoDocumento { get; set; }
}

public enum TipoDocumento
{
    /// <summary>
    /// Certidão de Nascimento.
    /// </summary>
    CertidaoNascimento = 1,

    /// <summary>
    /// Certidão de Casamento.
    /// </summary>
    CertidaoCasamento = 2,
}
