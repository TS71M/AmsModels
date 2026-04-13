namespace AmsModels;

public partial class Operation
{
    [Key]
    public int OperationId { get; set; }
    public int YearId { get; set; }
    public int AreaId { get; set; }
    public int JobId { get; set; }
    public DateTime OpeDat { get; set; }
    public decimal? Quantity { get; set; }
    public int ConBilNumId { get; set; }
    public string OpeDes { get; set; } = "";
    public bool? TaskWork { get; set; }

    public required Area Area { get; set; }
    public required ConBilNum ConBilNum { get; set; }
    public required Job Job { get; set; }
    public required Year Year { get; set; }


    public virtual ICollection<OperationHole> OperationHelps { get; set; } = [];
}