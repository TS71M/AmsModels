namespace AmsModels;

public class FieldType
{
    [Key]
    public int FieldTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(20)]
    public string FieldTypeName { get; set; } = "";

    [MaxLength(9)]
    public string? MarkerColor { get; set; }

    [MaxLength(512)]
    public string? MarkerIconUrl { get; set; }


    [JsonIgnore]
    public virtual ICollection<Field> Fields { get; set; } = [];
}