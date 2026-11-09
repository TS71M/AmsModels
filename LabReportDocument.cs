namespace AmsModels;

public sealed class LabReportDocument
{
    public int LabReportDocumentId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int FieldId { get; set; }
    public required Field Field { get; set; }
    public string ModuleKey { get; set; } = "";
    public string ContentHash { get; set; } = "";
    public string FileName { get; set; } = "";
    public string MimeType { get; set; } = "";
    public string RelativePath { get; set; } = "";
    public int ByteLength { get; set; }
    public int UploadedById { get; set; }
    public DateTime UploadedUtc { get; set; }
}
