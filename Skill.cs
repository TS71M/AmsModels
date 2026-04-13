namespace AmsModels;

public partial class Skill
{
    [Key]
    public int SkillId { get; set; }
    public int AreaId { get; set; }
    public int JobId { get; set; }
    public int StaffId { get; set; }

    public required Area Area { get; set; }
    public required Job Job { get; set; }
    public required Staff Staff { get; set; }
}