using CompanyName.ERPNext.Entities.Base;

namespace CompanyName.ERPNext.Entities.Assets;

/// <summary>
/// Represents a fixed asset in the organization.
/// Maps to schema.org/Product and schema.org/Thing concepts.
/// </summary>
public class Asset : AuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the asset.
    /// Maps to schema.org/name
    /// </summary>
    public string AssetName { get; set; }

    /// <summary>
    /// Gets or sets the asset category.
    /// Maps to schema.org/category
    /// </summary>
    public string AssetCategory { get; set; }

    /// <summary>
    /// Gets or sets the serial number of the asset.
    /// Maps to schema.org/serialNumber
    /// </summary>
    public string SerialNumber { get; set; }

    /// <summary>
    /// Gets or sets the purchase cost of the asset.
    /// Maps to schema.org/price
    /// </summary>
    public decimal PurchaseCost { get; set; }

    /// <summary>
    /// Gets or sets the purchase date of the asset.
    /// Maps to schema.org/purchaseDate
    /// </summary>
    public DateTimeOffset PurchaseDate { get; set; }

    /// <summary>
    /// Gets or sets the status of the asset.
    /// Maps to schema.org/itemCondition
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the description of the asset.
    /// Maps to schema.org/description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer of the asset.
    /// Maps to schema.org/manufacturer
    /// </summary>
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the model of the asset.
    /// Maps to schema.org/model
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the URL for the asset's image.
    /// Maps to schema.org/image
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL for more information about the asset.
    /// Maps to schema.org/url
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Gets or sets the brand of the asset.
    /// Maps to schema.org/brand
    /// </summary>
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the SKU (Stock Keeping Unit) of the asset.
    /// Maps to schema.org/sku
    /// </summary>
    public string SKU { get; set; }

    /// <summary>
    /// Gets or sets the weight of the asset.
    /// Maps to schema.org/weight
    /// </summary>
    public string Weight { get; set; }

    /// <summary>
    /// Gets or sets the height of the asset.
    /// Maps to schema.org/height
    /// </summary>
    public string Height { get; set; }

    /// <summary>
    /// Gets or sets the width of the asset.
    /// Maps to schema.org/width
    /// </summary>
    public string Width { get; set; }

    /// <summary>
    /// Gets or sets the depth of the asset.
    /// Maps to schema.org/depth
    /// </summary>
    public string Depth { get; set; }

    /// <summary>
    /// Gets or sets the Global Trade Item Number (GTIN) of the asset.
    /// Maps to schema.org/gtin
    /// </summary>
    public string GTIN { get; set; }
}
