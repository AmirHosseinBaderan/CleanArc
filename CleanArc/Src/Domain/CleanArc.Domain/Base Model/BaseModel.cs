
namespace CleanArc.Domain;

public record BaseModel
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
