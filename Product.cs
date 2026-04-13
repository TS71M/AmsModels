using Lib.Images;

namespace AmsModels;

public partial class Product
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }
    public bool Active { get; set; } = true;
    public string ProNam { get; set; } = "";
    public int AccountId { get; set; }
    public int? ProductTypeId { get; set; }
    public decimal Rate { get; set; } = 0;
    public decimal RecRat { get; set; }

    [ForeignKey(nameof(UniWei))]
    public int UniWeiId { get; set; }
    public int UniSurId { get; set; }
    public decimal Price { get; set; } = 0;
    public decimal Pack { get; set; } = 0;

    [ForeignKey(nameof(UniWeiPack))]
    public int UniWeiIdPack { get; set; }
    public bool Highlight { get; set; }
    public decimal Alarm { get; set; }
    public int? ImageId { get; set; }
    public bool IsPGR { get; set; } = false;
    public string SdsName { get; set; } = "";
    public string SdsPath { get; set; } = "";
    public DateTime? SdsUploadDt { get; set; }
    public int? SdsSize { get; set; }
    /// <summary>
    /// Application
    /// </summary>
    public decimal TotalQuantity = 0;
    public string TotalQuantityL =>
            TotalQuantity switch
            {
                < 1 => TotalQuantity.ToString("N3") + UniWeiPackL,
                < 10 => TotalQuantity.ToString("N2") + UniWeiPackL,
                < 50 => TotalQuantity.ToString("N1") + UniWeiPackL,
                _ => TotalQuantity.ToString("N0") + UniWeiPackL,
            };
    /// <summary>
    /// Labels
    /// </summary>
    public virtual string UniWeiL => UniWei.UnitShort;
    public virtual string UniWeiPackL => UniWeiPack.UnitShort;
    public virtual string UniSurL => UniSur.UnitShort;
    public virtual string RecRateLabel =>
            RecRat switch
            {
                < 1 => ProNam + " @ " + RecRat.ToString("N3") + UniWeiUniSurLabel,
                < 10 => ProNam + " @ " + RecRat.ToString("N2") + UniWeiUniSurLabel,
                < 50 => ProNam + " @ " + RecRat.ToString("N1") + UniWeiUniSurLabel,
                _ => ProNam + " @ " + RecRat.ToString("N0") + UniWeiUniSurLabel,
            };
    public virtual string UniWeiUniSurLabel => UniWeiL + '/' + UniSurL;
    //public string ProNamRateLabel => ProNam + " @ " + Rate + Label;
    public string ProNamRateLabel =>
             Rate switch
             {
                 < 1 => ProNam + " @ " + Rate.ToString("N3") + UniWeiUniSurLabel,
                 < 10 => ProNam + " @ " + Rate.ToString("N2") + UniWeiUniSurLabel,
                 < 50 => ProNam + " @ " + Rate.ToString("N1") + UniWeiUniSurLabel,
                 _ => ProNam + " @ " + Rate.ToString("N0") + UniWeiUniSurLabel,
             };

    public string AccountName => Account.AccDes;
    public string ProductTypeName => ProductType?.ProductTypeName ?? string.Empty;
    public string PricePerUnit => $"{Price}/{UniWeiPackL}";
    public string PackingSizeL => $"{Pack}/{UniWeiPackL}";
    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? AppImage { get; set; }
    public Account Account { get; set; } = null!;
    public Field? Field { get; set; }
    public Ibu Ibu { get; set; } = null!;
    public ProductType? ProductType { get; set; }
    public Unit UniWei { get; set; } = null!;
    public Unit UniWeiPack { get; set; } = null!;
    public Unit UniSur { get; set; } = null!;

    public virtual ICollection<AgrAppProduct> AgrAppProducts { get; set; } = [];
    public virtual ICollection<PriInq> PriInqs { get; set; } = [];
    public virtual ICollection<ProductChemical> ProdChems { get; set; } = [];
    public virtual ICollection<ProductLabel> ProductLabels { get; set; } = [];
    public virtual ICollection<ConBil> ConBils { get; set; } = [];
    public virtual ICollection<Inventory> Inventories { get; set; } = [];
    public virtual ICollection<DelBil> DelBils { get; set; } = [];
    public virtual ICollection<ProductFertilizerType> ProductFertTypes { get; set; } = [];
    public virtual ICollection<ProductSupplier> ProductSuppliers { get; set; } = [];
    public virtual ICollection<Order> Orders { get; set; } = [];
    public virtual ICollection<ProductNutrient> ProductNutrients { get; set; } = [];
    public virtual ICollection<ProductSupplement> ProductSupplements { get; set; } = [];
}
