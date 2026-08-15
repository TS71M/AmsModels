using Lib.Enums;

namespace AmsModels;

public partial class Machine
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MachineId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }

    [Required]
    public int StationedIbuId { get; set; }

    public int? FieldId { get; set; }
    public int? ManufacturerId { get; set; }
    public int? SupplierId { get; set; }
    public int? MachineCategoryId { get; set; }

    [Required, MaxLength(120)]
    public string Name { get; set; } = "";

    public MachineryApplicationCapability ApplicationCapability { get; set; }

    [MaxLength(100)]
    public string CategoryName { get; set; } = "";

    [MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [MaxLength(250)]
    public string ModelName { get; set; } = "";

    [MaxLength(250)]
    public string ModelNumber { get; set; } = "";

    [MaxLength(120)]
    public string? RegistrationNumber { get; set; }

    [MaxLength(250)]
    public string? SerialNumber { get; set; }

    [MaxLength(250)]
    public string? InventoryNumber { get; set; }

    public int ServiceLife { get; set; }
    public decimal PriceOfPurchase { get; set; }
    public DateTime? DateOfPurchase { get; set; }
    public int StartingHours { get; set; }
    public DateTime? DateOfSale { get; set; }
    public decimal PriceOfSale { get; set; }
    public bool Active { get; set; } = true;
    public bool Blocked { get; set; }
    public bool Broken { get; set; }
    public bool IsDefaultApplicationMachine { get; set; }

    [Precision(10, 3)]
    public decimal? WorkingWidth { get; set; }
    public int? WorkingWidthUnitId { get; set; }

    [Precision(12, 3)]
    public decimal? Capacity { get; set; }
    public int? CapacityUnitId { get; set; }

    [Precision(12, 3)]
    public decimal? DefaultApplicationRate { get; set; }
    public int? DefaultApplicationRateUnitId { get; set; }
    public int? DefaultApplicationAreaUnitId { get; set; }

    public DateOnly? LastCalibratedOn { get; set; }
    public DateOnly? CalibrationDueOn { get; set; }

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    public int? MachinePictureId { get; set; }
    public int MacPic { get; set; }

    public required Ibu Ibu { get; set; }
    public required Ibu StationedIbu { get; set; }
    public Field? Field { get; set; }
    public MachineCategory? MachineCategory { get; set; }
    public Manufacturer? Manufacturer { get; set; }
    public Supplier? Supplier { get; set; }
    public Unit? WorkingWidthUnit { get; set; }
    public Unit? CapacityUnit { get; set; }
    public Unit? DefaultApplicationRateUnit { get; set; }
    public Unit? DefaultApplicationAreaUnit { get; set; }

    public virtual ICollection<MachinePicture> MachineryPictures { get; set; } = [];
    public virtual ICollection<TaskWorkMachine> TaskWorkMachines { get; set; } = [];
    public virtual ICollection<ApplicationPlanItem> PlannedApplications { get; set; } = [];
    public virtual ICollection<ApplicationExecution> ApplicationExecutions { get; set; } = [];
}
