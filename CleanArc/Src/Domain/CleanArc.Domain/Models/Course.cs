namespace CleanArc.Domain;

public record Course : BaseModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }
}
