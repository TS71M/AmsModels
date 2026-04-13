namespace AmsModels;

public partial class IbuYearActive
{
    [Key]
    public int IbuYearActiveId { get; set; }
    public int IbuId { get; set; }
    public int YearId { get; set; }
    public bool Active { get; set; } = true;

    public required Ibu Ibu { get; set; }
    public required Year Year { get; set; }
}