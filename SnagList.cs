using Lib.Images;

namespace AmsModels;

public class SnagList
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SnagListId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }
    public int AreaId { get; set; }
    public int HoleId { get; set; }
    [ForeignKey(nameof(AssignedUser))]
    public int? AssignedUserId { get; set; }

    [ForeignKey(nameof(User))]
    public int CreatedById { get; set; }

    [ForeignKey(nameof(SnagImg))]
    public int? StartImgId { get; set; }

    [Required, MaxLength(45)]
    public string Title { get; set; } = "";

    [Required, MaxLength(450)]
    public string Description { get; set; } = "";
    public DateTime SnagDate { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public int Priority { get; set; }
    public bool Completed { get; set; }
    public DateTime? CompletionDate { get; set; } = null;
    [MaxLength(500)]
    public string? CompletionRemarks { get; set; }
    public int? CompletionDurationMinutes { get; set; }
    public DateTime? AcceptDate { get; set; }

    [ForeignKey(nameof(SnagCompletedImg))]
    public int? CompletedImageId { get; set; }

    public virtual string CreatedByName => User.Name?.FullName ?? "-";
    public virtual string AssignedTo => AssignedUser?.FullNameSnapshot ?? AssignedUser?.UserName ?? "not yet assigned";
    public virtual string AreaHole => $"{Area.AreaName} {Hole.HolShoNam}";
    public virtual TimeSpan? ReactionTime => AcceptDate.HasValue ? AcceptDate.Value - SnagDate : null;
    public virtual TimeSpan? SolvingTime => CompletionDate.HasValue ? CompletionDate.Value - SnagDate : null;
    public virtual TimeSpan? ExecutionTime => SolvingTime.HasValue && ReactionTime.HasValue ? new TimeSpan(SolvingTime.Value.Ticks - ReactionTime.Value.Ticks) : null;
    string ReactionTimeDays => ReactionTime.HasValue && ReactionTime.Value.Days > 0 ? $"{ReactionTime.Value.Days} days" : "";
    public virtual string ReactionTimeTxt => ReactionTime.HasValue ?
        $"Reacted in {ReactionTimeDays} {ReactionTime.Value.Hours}h {ReactionTime.Value.Minutes}m {ReactionTime.Value.Seconds}s" :
        "";
    string ExecutionTimeDays => ExecutionTime.HasValue && ExecutionTime.Value.Days > 0 ? $"{ExecutionTime.Value.Days} days" : "";
    public virtual string ExecutionTimeTxt => ExecutionTime.HasValue ? $"Executed in {ExecutionTimeDays} {ExecutionTime.Value.Hours}h {ExecutionTime.Value.Minutes}m {ExecutionTime.Value.Seconds}s" : "Not yet completed";
    string SolvingTimeDays => SolvingTime.HasValue && SolvingTime.Value.Days > 0 ? $"{SolvingTime.Value.Days} days" : "";
    public virtual string SolvingTimeTXt => SolvingTime.HasValue ? $"Solved in {SolvingTimeDays} {SolvingTime.Value.Hours}h {SolvingTime.Value.Minutes}m {SolvingTime.Value.Seconds}s" : "Not yet solved!";
    public string Image => ImageX.ImageToString(SnagImg?.ImageFile) ?? GlobalsX.NoImagePath;
    public string CompletedImage => ImageX.ImageToString(SnagCompletedImg?.ImageFile) ?? GlobalsX.NoImagePath;

    public virtual AppImage? SnagImg { get; set; }
    public virtual AppImage? SnagCompletedImg { get; set; }
    public required Area Area { get; set; }
    public required Field Field { get; set; }
    public required Hole Hole { get; set; }
    public User? AssignedUser { get; set; }
    public required User User { get; set; }
}
