namespace AmsModels;

public partial class TaskArea
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskAreaId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int GlobalId { get; set; }
    public int AreaId { get; set; }
    public int TaskOrientationId { get; set; }
    public bool CleanUp { get; set; }
    public bool Baskets { get; set; }

    public required Area Area { get; set; }
    public required TaskGlobal TaskGlobal { get; set; }
    public required TaskOrientation TaskOrientation { get; set; }

}