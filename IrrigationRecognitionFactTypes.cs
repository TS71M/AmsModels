namespace AmsModels;

public static class IrrigationRecognitionFactTypes
{
    public const string VisibleMarking = "visible-marking";
    public const string BodyConstruction = "body-construction";
    public const string NozzleArrangement = "nozzle-arrangement";
    public const string CapFeature = "cap-feature";
    public const string RiserFeature = "riser-feature";
    public const string ArcComponent = "arc-component";
    public const string DriveMechanism = "drive-mechanism";
    public const string DimensionRatio = "dimension-ratio";
    public const string InletOrBodySize = "inlet-or-body-size";
    public const string OtherVisual = "other-visual";

    public static IReadOnlyList<string> All { get; } =
    [
        VisibleMarking,
        BodyConstruction,
        NozzleArrangement,
        CapFeature,
        RiserFeature,
        ArcComponent,
        DriveMechanism,
        DimensionRatio,
        InletOrBodySize,
        OtherVisual
    ];

    public static string? Canonicalize(string? value)
        => All.FirstOrDefault(x => string.Equals(x, value?.Trim(), StringComparison.OrdinalIgnoreCase));
}
