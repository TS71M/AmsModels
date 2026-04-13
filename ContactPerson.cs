namespace AmsModels;

public class ContactPerson
{
    [Key]
    public int ContactPersonId { get; set; }

    public int? NameId { get; set; }

    [Required, MaxLength(100)]
    public string Position { get; set; } = "";

    public int? ContactDetailsId { get; set; }

    public ContactDetail? ContactDetails { get; set; }
    public Name? Name { get; set; }

}
