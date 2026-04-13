namespace AmsModels;

public partial class SoiTesSat
{
    [Key]
    public int SoiTesSatId { get; set; }
    public int AreaId { get; set; }
    public int HoleId { get; set; }
    public DateTime SoiTesDat { get; set; }
    //public decimal PH { get; set; }
    //public decimal SolubleSalts { get; set; }
    //public decimal Chloride { get; set; }
    //public decimal NitrateNo3N { get; set; }
    //public decimal Bicarbonate { get; set; }
    //public decimal Sulfur { get; set; }
    //public decimal Phosphorus { get; set; }
    //public decimal CalciumPpm { get; set; }
    //public decimal MagnesiumPpm { get; set; }
    //public decimal PotassiumPpm { get; set; }
    //public decimal SodiumPpm { get; set; }
    //public decimal Boron { get; set; }
    //public decimal Iron { get; set; }
    //public decimal Manganese { get; set; }
    //public decimal Copper { get; set; }
    //public decimal Zinc { get; set; }
    //public decimal Aluminium { get; set; }
    //public decimal Ammonium { get; set; }
    //public decimal Esp { get; set; }

    public required Area Area { get; set; }
    public required Hole Hole { get; set; }

    public virtual ICollection<SoiTesSatChem> SoiTesSatChems { get; set; } = [];
}