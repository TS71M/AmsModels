namespace AmsModels;

/// <summary>
/// Associates one physical maintained Surface with every golf hole that uses it.
/// Surface.HoleId remains the compatibility/primary hole during the client migration.
/// </summary>
public sealed class SurfaceHoleAssignment
{
    public int SurfaceId { get; set; }
    public int HoleId { get; set; }

    public required Surface Surface { get; set; }
    public required Hole Hole { get; set; }
}
