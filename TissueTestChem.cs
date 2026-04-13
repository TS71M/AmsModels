namespace AmsModels;

public class TissueTestChem
{
    [Key]
    public int TissueTestChemId { get; set; }

    public int TissueTestId { get; set; }
    public int ChemId { get; set; }

    public decimal Value { get; set; }

    public required TissueTest TissueTest { get; set; }
    public required Chemical Chem { get; set; }
}