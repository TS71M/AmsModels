namespace AmsModels;

public class SoiTesSatChem
{
    [Key]
    public int SoiTesSatChemId { get; set; }

    public int SoiTesSatId { get; set; }
    public int ChemId { get; set; }

    public decimal Value { get; set; }

    public required Chemical Chem { get; set; }
    public required SoiTesSat SoiTesSat { get; set; }

}