namespace AmsModels;

public partial class Machine
{
    [Key]
    public int MachineId { get; set; }
    public int FieldId { get; set; }
    public int ManufacturerId { get; set; }
    public int SupplierId { get; set; }
    public int MachineCategoryId { get; set; }
    public string ModelName { get; set; } = "";
    public string ModelNumber { get; set; } = "";
    public string SerialNumber { get; set; } = "";
    public string InventoryNumber { get; set; } = "";
    public int ServiceLife { get; set; }
    public decimal PriceOfPurchase { get; set; }
    public DateTime? DateOfPurchase { get; set; }
    public int StartingHours { get; set; }
    public DateTime? DateOfSale { get; set; }
    public decimal PriceOfSale { get; set; }
    public bool Active { get; set; } = true;
    public bool? Blocked { get; set; }
    public bool? Broken { get; set; }
    public int? MachinePictureId { get; set; }
    public int MacPic { get; set; }

    public required Field Field { get; set; }
    public required MachineCategory MachineCategory { get; set; }
    public required Manufacturer Manufacturer { get; set; }
    public required Supplier Supplier { get; set; }

    public virtual ICollection<MachinePicture> MachineryPictures { get; set; } = [];
    public virtual ICollection<TaskWorkMachine> TaskWorkMachines { get; set; } = [];
}