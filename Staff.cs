using Lib.Images;

namespace AmsModels;

public partial class Staff
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StaffId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }
    public bool Active { get; set; } = true;

    [Required, Display(Name = "Staff Id"), MaxLength(100)]
    public string StaNum { get; set; } = "";
    public int? NameId { get; set; }

    [Display(Name = "Staff Pos")]
    public int StaPosId { get; set; }
    public int? AddressId { get; set; }
    public int? CommunicationDetailsId { get; set; }
    public DateTime Birthday { get; set; }

    [Display(Name = "Start Date")]
    public DateTime DatOfEnt { get; set; }

    [Display(Name = "End Date")]
    public DateTime? DatOfExi { get; set; }
    public int? ImageId { get; set; }
    public int? UserId { get; set; }
    public int RandomNumber = 0;

    public virtual string FullName => Name?.FullName ?? "no name";
    public virtual string Position => StaPos.StaPosDes;
    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoPerson);

    public Address? Address { get; set; }
    public AppImage? AppImage { get; set; }
    public ContactDetail? ContactDetails { get; set; }
    public required Field Field { get; set; }
    public Name? Name { get; set; }
    public required StaPos StaPos { get; set; }
    public User? User { get; set; }

    public virtual ICollection<Incentive> Incentives { get; set; } = [];
    public virtual ICollection<ManagerOnDuty> ManagersOnDuty { get; set; } = [];
    public virtual ICollection<ShiftPlanner> ShiftPlanners { get; set; } = [];
    public virtual ICollection<Skill> Skillss { get; set; } = [];
    public virtual ICollection<SnagList> SnagLists { get; set; } = [];
    public virtual ICollection<StaPay> StaPays { get; set; } = [];
    public virtual ICollection<TaskWork> TaskWorks { get; set; } = [];
}