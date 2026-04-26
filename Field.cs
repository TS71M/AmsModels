using static Lib.Enums.RiskLevels;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId))]
[Index(nameof(JurisdictionId))]
[Index(nameof(ClimateZoneId))]
[Index(nameof(IbuId), nameof(FieldName), IsUnique = true)]
[Index(nameof(IbuId), nameof(Active))]
public class Field
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int IbuId { get; set; }
    public int? FieldTypeId { get; set; }
    public int? JurisdictionId { get; set; }
    public int? ClimateZoneId { get; set; }
    public int? PrimaryRiskAreaId { get; set; }

    [Required, MaxLength(100)]
    public string FieldName { get; set; } = "";
    public bool Active { get; set; } = true;

    [Precision(4, 1)]
    public decimal Elevation { get; set; }

    [Precision(10, 1)]
    public decimal TotalSurface { get; set; }

    [Range(0, 100)]
    public int NumberOfHoles { get; set; }

    [Range(1900, 2100), Display(Name = "Year of Construction")]
    public int? YearOfConstruction { get; set; }

    [Range(1900, 2100), Display(Name = "Year of Irrigation System")]
    public int? YearOfIrrigationSystem { get; set; }

    [Display(Name = "Back heads around Greens")]
    public bool BacHeaAroGre { get; set; } = false;

    [MaxLength(250), Display(Name = "Irrigation System Type")]
    public string IrrigationSystem { get; set; } = "";

    [Range(0, 10), Display(Name = "Water sources")]
    public int WaterSources { get; set; }

    [Display(Name = "Weather Station")]
    public bool WeatherStation { get; set; } = true;

    [Range(0, 100)]
    public int Tolerance { get; set; }

    [ForeignKey(nameof(SurfaceUni))]
    public int? SurfaceUniId { get; set; }

    [ForeignKey(nameof(TotalSurfaceUni))]
    public int? TotalSurfaceUniId { get; set; }

    [ForeignKey(nameof(CutUniLen))]
    public int? CutUniLenId { get; set; }

    [ForeignKey(nameof(GreenSpeedUniLen))]
    public int? GreenSpeedUniLenId { get; set; }

    [ForeignKey(nameof(TempUni))]
    public int? TempUniId { get; set; }

    [ForeignKey(nameof(RainUni))]
    public int? RainUniId { get; set; }

    [ForeignKey(nameof(ClippingsUni))]
    public int? ClippingsUniId { get; set; }

    [ForeignKey(nameof(WindUni))]
    public int? WindUniId { get; set; }

    [ForeignKey(nameof(ElevationUniLen))]
    public int? ElevationUniLenId { get; set; }

    public bool StartInventory { get; set; } = false;
    public bool UsePlanning { get; set; } = true;
    public bool EnterWeatherManually { get; set; } = true;

    [Range(0, 100)]
    public int DollarSpotMedium { get; set; } = 20;

    [Range(0, 100)]
    public int DollarSpotHigh { get; set; } = 30;

    public RiskLevel DollarSpotRisk { get; set; } = RiskLevel.None;
    public RiskLevel PythiumRisk { get; set; } = RiskLevel.None;
    public RiskLevel MicrodochiumRisk { get; set; } = RiskLevel.None;
    public RiskLevel DewRisk { get; set; } = RiskLevel.None;
    public RiskLevel FrostRisk { get; set; } = RiskLevel.None;
    public RiskLevel HeatStressRisk { get; set; } = RiskLevel.None;
    public RiskLevel AnthracnoseRisk { get; set; } = RiskLevel.None;

    public int? AddressId { get; set; }
    public int? ContactId { get; set; }
    public int? ArchitectId { get; set; }
    public int? DoGId { get; set; }
    public int? ImageId { get; set; }
    public int StdWorkDay { get; set; }
    public int? CoordinateId { get; set; }
    public TimeSpan? CommonStartTime { get; set; }

    public virtual string ElevationTxt
    {
        get
        {
            var u = ElevationUniLen?.UnitShort;
            return string.IsNullOrWhiteSpace(u) ? $"{Elevation}" : $"{Elevation} {u}";
        }
    }
    public virtual string TotalSurfaceTxt
    {
        get
        {
            var u = TotalSurfaceUni?.UnitShort;
            return string.IsNullOrWhiteSpace(u) ? $"{TotalSurface}" : $"{TotalSurface} {u}";
        }
    }
    public virtual string FieldAddress
    {
        get
        {
            var parts = new[]
            {
                Address?.Address1?.Trim(),
                Address?.Town?.Trim(),
                Address?.Country?.CountryName?.Trim()
            }.Where(x => !string.IsNullOrWhiteSpace(x));

            return string.Join(", ", parts);
        }
    }

    public virtual string TemperatureUnit => TempUni?.UnitShort ?? "No Temperature Unit selected yet";
    public virtual string RainUnit => RainUni?.UnitShort ?? "No Rain Unit selected yet";
    public virtual string WindSpeedUnit => WindUni?.UnitShort ?? "No Speed Unit selected yet";
    public virtual string GreenSpeedUnit => GreenSpeedUniLen?.UnitShort ?? "No Speed Unit selected yet";
    public virtual string ClippingsUnit => ClippingsUni?.UnitShort ?? "No Clippings Unit selected yet";
    public virtual string CuttingsUnit => CutUniLen?.UnitShort ?? "No Cutting Heights Unit selected yet";
    public virtual string SurfaceUnit => SurfaceUni?.UnitShort ?? "No Surface Unit selected yet";
    public virtual string TotalSurfaceUnit => SurfaceUni?.UnitShort ?? "No total Surface Unit selected yet";
    public virtual string ElevationUnit => ElevationUniLen?.UnitShort ?? "No Elevation Unit selected yet";
    public virtual Guid? CoordinatePubId => Coordinate?.PubId;
    public virtual Guid? ClimateZonePubId => ClimateZone?.PubId;
    public virtual Guid? AppImagePubId => AppImage?.PubId;
    public virtual string FieldTypeTxt => FieldType?.FieldTypeName ?? "No Field Type selected yet";
    public string MarkerColor => FieldType?.MarkerColor ?? string.Empty;
    public string MarkerIconUrl => FieldType?.MarkerIconUrl ?? string.Empty;

    public AppImage? AppImage { get; set; }
    public Address? Address { get; set; }
    public Architect? Architect { get; set; }
    public ContactDetail? Contact { get; set; }
    public Coordinate? Coordinate { get; set; }
    public FieldType? FieldType { get; set; }
    public DirectorOfGolf? DoG { get; set; }
    public required Ibu Ibu { get; set; }
    public Unit? ClippingsUni { get; set; }
    public Unit? CutUniLen { get; set; }
    public Unit? GreenSpeedUniLen { get; set; }
    public Unit? RainUni { get; set; }
    public Unit? SurfaceUni { get; set; }
    public Unit? ElevationUniLen { get; set; }
    public Unit? TotalSurfaceUni { get; set; }
    public Unit? WindUni { get; set; }
    public Unit? TempUni { get; set; }
    public Jurisdiction? Jurisdiction { get; set; }
    public ClimateZone? ClimateZone { get; set; }
    [ForeignKey(nameof(PrimaryRiskAreaId))]
    public Area? PrimaryRiskArea { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = [];
    public virtual ICollection<BudgetNum> BudgetNums { get; set; } = [];
    public virtual ICollection<FieldClimateNormal> ClimateNormals { get; set; } = [];
    public virtual ICollection<ClippArea> ClippAreas { get; set; } = [];
    public virtual ICollection<Diary> Diaries { get; set; } = [];
    public virtual ICollection<Event> Events { get; set; } = [];
    public virtual ICollection<GreenSpeed> GreenSpeeds { get; set; } = [];
    public virtual ICollection<HoleGroup> HoleGroups { get; set; } = [];
    public virtual ICollection<Hole> Holes { get; set; } = [];
    public virtual ICollection<Machine> Machines { get; set; } = [];
    public virtual ICollection<PinPos> PinPoses { get; set; } = [];
    public virtual ICollection<Product> Products { get; set; } = [];
    public virtual ICollection<Project> Projects { get; set; } = [];
    public virtual ICollection<ShiftPlanner> ShiftPlanners { get; set; } = [];
    public virtual ICollection<SnagList> SnagLists { get; set; } = [];
    public virtual ICollection<Surface> Surfaces { get; set; } = [];
    public virtual ICollection<TaskGlobal> TaskGlobals { get; set; } = [];
    public virtual ICollection<IbuRelationshipField> IbuRelationshipFields { get; set; } = [];
    public virtual ICollection<UserFieldPermission> UserFieldPermissions { get; set; } = [];
    public virtual ICollection<WeatherObservation> WeatherObservations { get; set; } = [];
    public virtual ICollection<WeatherForecastHour> WeatherForecastHours { get; set; } = [];
    public ICollection<FieldWeedTimingOverride> FieldWeedTimingOverrides { get; set; } = [];
    public FieldProcurementSetting? ProcurementSetting { get; set; }
    public virtual ICollection<PurchaseRequisition> PurchaseRequisitions { get; set; } = [];

}
