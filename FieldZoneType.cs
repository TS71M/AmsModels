using System.ComponentModel.DataAnnotations;

namespace AmsModels;

public enum FieldZoneType
{
    [Display(Name = "Unknown")]
    Unknown = 0,
    [Display(Name = "Field boundary")]
    Boundary = 1
}
