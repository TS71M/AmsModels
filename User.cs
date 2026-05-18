using Microsoft.AspNetCore.Identity;

namespace AmsModels;

public partial class User : IdentityUser<int>
{
    [Key] 
    [Column("UserId")]
    public override int Id
    {
        get => base.Id;
        set => base.Id = value;
    }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, EmailAddress, MaxLength(250)]
    public override string? Email
    {
        get => base.Email;
        set => base.Email = value ?? throw new ArgumentNullException(nameof(value), "Email cannot be null");
    }

    [Required, MinLength(4)]
    public override string? UserName { get => base.UserName; set => base.UserName = value; }
    public int IbuId { get; set; }
    public bool Active { get; set; } = true;
    public bool ThisWeek { get; set; }
    public bool NextWeek { get; set; }
    public bool Irrigation { get; set; }
    public bool Stock { get; set; }
    public bool Today { get; set; }
    public bool History { get; set; }
    public int Tolerance { get; set; } = 0;
    public int WkOfWarn { get; set; } = 4;
    public bool MaskCompTasks { get; set; }
    public int? PlanningYearId { get; set; }
    public int LoadYears { get; set; } = 3;
    public bool ConsiderMlsn { get; set; }
    public bool CheckApps { get; set; }
    public bool CheckOrders { get; set; }
    public bool CheckEt { get; set; }
    public bool ShowLastDays { get; set; }
    public bool ShowProgress { get; set; }
    public int? ContactDetailsId { get; set; }
    public int? ManagerUserId { get; set; }
    public int? UserPositionId { get; set; }
    public int? AccessProfileId { get; set; }

    [Display(Name = "Consider skills")]
    public bool ConsiderSkills { get; set; }

    [Display(Name = "Randomize assignments")]
    public bool RandomizeAssignments { get; set; }
    public int? NameId { get; set; }

    public int? ImageId { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }
    public DateTime? LastSeenUtc { get; set; }

    [MaxLength(250)]
    public string IbuNameSnapshot { get; set; } = "";

    public Guid IbuPubIdSnapshot { get; set; }

    [MaxLength(250)]
    public string FullNameSnapshot { get; set; } = "";

    public int? PreferredCountryId { get; set; }
    public int? PreferredLanguageId { get; set; }
    public int? VisualizationTempUnitId { get; set; }
    public int? VisualizationRainUnitId { get; set; }
    public int? VisualizationWindUnitId { get; set; }

    public virtual string RolesTxt => UserRole.Count > 0 ? string.Join(" ,", [.. UserRole.Select(ur => ur.Role.Name)]) : "no Roles available";

    public Country? PreferredCountry { get; set; }
    public Language? PreferredLanguage{ get; set; }
    public Unit? VisualizationTempUnit { get; set; }
    public Unit? VisualizationRainUnit { get; set; }
    public Unit? VisualizationWindUnit { get; set; }
    public AppImage? UserImg { get; set; }
    public Name? Name { get; set; }
    public Ibu? Ibu { get; set; }
    public ContactDetail? ContactDetail { get; set; }
    public User? ManagerUser { get; set; }
    public UserPosition? UserPosition { get; set; }
    public IbuAccessProfile? AccessProfile { get; set; }
    public Year? Year { get; set; }
    public virtual ICollection<User> DirectReports { get; set; } = [];
    public virtual ICollection<Incentive> Incentives { get; set; } = [];
    public virtual ICollection<ManagerOnDuty> ManagersOnDuty { get; set; } = [];
    public virtual ICollection<ShiftPlanner> ShiftPlanners { get; set; } = [];
    public virtual ICollection<Skill> Skillss { get; set; } = [];
    public virtual ICollection<TaskWork> TaskWorks { get; set; } = [];
    public virtual ICollection<UserRole> UserRole { get; set; } = [];
    public virtual ICollection<BudgetNum> BudgetNums { get; set; } = [];
    public virtual ICollection<Event> Events { get; set; } = [];
    public virtual ICollection<Ibu> Ibus { get; set; } = [];
    public virtual ICollection<OrdNum> OrdNums { get; set; } = [];
    public virtual ICollection<LoginLog> Logins { get; set; } = [];
    public virtual ICollection<MobileBugReport> MobileBugReports { get; set; } = [];
    public virtual ICollection<AssistantConversationLog> AssistantConversationLogs { get; set; } = [];
    public virtual ICollection<UserSession> Sessions { get; set; } = [];
    public virtual ICollection<PushDevice> PushDevices { get; set; } = [];
    public virtual ICollection<UserReportingLine> ReportingLines { get; set; } = [];
    public virtual ICollection<UserReportingLine> DirectReportReportingLines { get; set; } = [];
    public virtual ICollection<WorkConversationParticipant> WorkConversationParticipants { get; set; } = [];
    public virtual ICollection<WorkMessage> WorkMessages { get; set; } = [];
    [InverseProperty(nameof(SnagList.User))]
    public virtual ICollection<SnagList> CreatedSnagLists { get; set; } = [];

    [InverseProperty(nameof(SnagList.AssignedUser))]
    public virtual ICollection<SnagList> AssignedSnagLists { get; set; } = [];
    public virtual ICollection<AppImage> UploadedImages { get; set; } = [];
    public virtual ICollection<DiseaseTrainingExample> SubmittedDiseaseTrainingExamples { get; set; } = [];
    public virtual ICollection<DiseaseTrainingExample> ReviewedDiseaseTrainingExamples { get; set; } = [];
    public virtual ICollection<UserFieldPermission> UserFieldPermissions { get; set; } = [];
    public virtual ICollection<FieldProcurementSetting> ManagedFieldProcurementSettings { get; set; } = [];
    public virtual ICollection<PurchaseRequisition> RequestedPurchaseRequisitions { get; set; } = [];
    public virtual ICollection<PurchaseRequisition> ManagedPurchaseRequisitions { get; set; } = [];
    public virtual ICollection<UserTemporaryReplacement> TemporaryReplacementsForAbsence { get; set; } = [];
    public virtual ICollection<UserTemporaryReplacement> TemporaryReplacementAssignments { get; set; } = [];
    public virtual ICollection<UserPermissionOverride> PermissionOverrides { get; set; } = [];
}
