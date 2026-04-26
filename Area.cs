namespace AmsModels;

[Index(nameof(FieldId))]
[Index(nameof(AreaGroupId))]
[Index(nameof(PubId), IsUnique = true)]
public partial class Area
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AreaId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AreaGroupId { get; set; }

    [Required]
    public int FieldId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public string AreaName { get; set; } = "";

    public bool Planning { get; set; }
    public bool ClippingsRemoved { get; set; }
    public int Color { get; set; } = 0x7ED321;

    [Precision(3, 1)]
    public decimal NMaxMonth { get; set; }

    [Precision(5, 2)]
    public decimal TempOpt { get; set; }

    [Precision(5, 2)]
    public decimal EtThreshold { get; set; }

    public bool Irrigated { get; set; }
    public bool Report { get; set; }

    [Precision(5, 2)]
    public decimal Whc { get; set; }

    public bool HasSurface { get; set; }
    public bool GreenSpeed { get; set; }

    public int BaseTemp { get; set; } = 10;
    public int GddDays { get; set; }

    public int DollarSpotMedium { get; set; } = 20;
    public int DollarSpotHigh { get; set; } = 30;

    public required AreaGroup AreaGroup { get; set; }
    public required Field Field { get; set; }

    public virtual ICollection<AgrTask> AgrTasks { get; set; } = [];
    public virtual ICollection<AreaComposition> AreaCompositions { get; set; } = [];
    public virtual ICollection<AreaCompositionPhoto> AreaCompositionPhotos { get; set; } = [];
    public virtual ICollection<ClippArea> ClippAreas { get; set; } = [];
    public virtual ICollection<CutHei> CutHeis { get; set; } = [];
    public virtual ICollection<Expense> Expenses { get; set; } = [];
    public virtual ICollection<GreenSpeed> GreenSpeeds { get; set; } = [];
    public virtual ICollection<IrrigationLog> IrrLogs { get; set; } = [];
    public virtual ICollection<Operation> Operations { get; set; } = [];
    public virtual ICollection<SnagList> SnagLists { get; set; } = [];
    public virtual ICollection<Skill> Skillss { get; set; } = [];
    public virtual ICollection<SoiTesSat> SoiTesSats { get; set; } = [];
    public virtual ICollection<Surface> Surfaces { get; set; } = [];
    public virtual ICollection<TaskArea> TaskAreas { get; set; } = [];
    public virtual ICollection<TissueTest> TissueTests { get; set; } = [];
}
