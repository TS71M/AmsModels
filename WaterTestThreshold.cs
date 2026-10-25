namespace AmsModels;

// Water result codes include hardness and conductivity as well as nutrients;
// they cannot be represented by the soil chemical/extraction-method key.
public sealed class WaterTestThreshold
{
    public int WaterTestThresholdId { get; set; }
    public int? IbuId { get; set; }
    public int? FieldId { get; set; }
    [Required, MaxLength(50)] public string ResultCode { get; set; } = "";
    [Precision(18, 4)] public decimal? MinValue { get; set; }
    [Precision(18, 4)] public decimal? OptValue { get; set; }
    [Precision(18, 4)] public decimal? MaxValue { get; set; }
    public Ibu? Ibu { get; set; }
    public Field? Field { get; set; }
}
