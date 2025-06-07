using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Enums;
using BaseCompany.ErpModel.Sales;
using BaseCompany.ErpModel.Purchase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseCompany.ErpModel.Inventory;

/// <summary>
/// Represents an item or product available for sale or purchase.
/// Maps to schema.org/Product concept.
/// </summary>
public class Item : AuditableEntity
{
    /// <summary>
    /// Gets or sets the unique item code.
    /// Maps to schema.org/productID
    /// </summary>
    [Required(ErrorMessage = "Item code is required")]
    [MaxLength(50)]
    public string ItemCode { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the item.
    /// Maps to schema.org/name
    /// </summary>
    [Required(ErrorMessage = "Item name is required")]
    [MaxLength(100)]
    public string ItemName { get; set; }
    
    /// <summary>
    /// Gets or sets the type of item.
    /// Maps to schema.org/category
    /// </summary>
    [Required]
    public ItemType ItemType { get; set; } = ItemType.Inventory;
    
    /// <summary>
    /// Gets or sets the description of the item.
    /// Maps to schema.org/description
    /// </summary>
    [MaxLength(1000)]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or sets the unit of measure for the item.
    /// Maps to schema.org/unitText
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string UnitOfMeasure { get; set; }
    
    /// <summary>
    /// Gets or sets the standard selling price of the item.
    /// Maps to schema.org/price
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
    public decimal StandardSellingPrice { get; set; }
    
    /// <summary>
    /// Gets or sets the standard buying price of the item.
    /// Maps to schema.org/acquireLicensePage (semantic approximation)
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
    public decimal StandardBuyingPrice { get; set; }
    
    /// <summary>
    /// Gets or sets whether the item is maintained in inventory.
    /// </summary>
    public bool IsStocked { get; set; } = true;
    
    /// <summary>
    /// Gets or sets the minimum inventory level before reordering.
    /// </summary>
    [Range(0, double.MaxValue)]
    public decimal ReorderLevel { get; set; }
    
    /// <summary>
    /// Gets or sets the quantity to reorder when inventory is low.
    /// </summary>
    [Range(0, double.MaxValue)]
    public decimal ReorderQuantity { get; set; }
    
    /// <summary>
    /// Gets or sets the lead time for ordering this item (in days).
    /// </summary>
    [Range(0, int.MaxValue)]
    public int LeadTimeDays { get; set; }
    
    /// <summary>
    /// Gets or sets whether the item is active or discontinued.
    /// </summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>
    /// Gets or sets whether the item can be sold.
    /// </summary>
    public bool IsSellable { get; set; } = true;
    
    /// <summary>
    /// Gets or sets whether the item can be purchased.
    /// </summary>
    public bool IsPurchasable { get; set; } = true;
    
    /// <summary>
    /// Gets or sets the sales order items that use this item.
    /// </summary>
    public ICollection<SalesOrderItem> SalesOrderItems { get; set; } = new List<SalesOrderItem>();
    
    /// <summary>
    /// Gets or sets the purchase order items that use this item.
    /// </summary>
    public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    /// <summary>
    /// Gets or sets the brand of the item.
    /// Maps to schema.org/brand
    /// </summary>
    [MaxLength(100)]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer of the item.
    /// Maps to schema.org/manufacturer
    /// </summary>
    [MaxLength(100)]
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the model of the item.
    /// Maps to schema.org/model
    /// </summary>
    [MaxLength(100)]
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the SKU (Stock Keeping Unit) of the item.
    /// Maps to schema.org/sku
    /// </summary>
    [MaxLength(50)]
    public string SKU { get; set; }

    /// <summary>
    /// Gets or sets the Global Trade Item Number (GTIN) of the item.
    /// Maps to schema.org/gtin
    /// </summary>
    [MaxLength(50)]
    public string GTIN { get; set; }

    /// <summary>
    /// Gets or sets the URL of the item's image.
    /// Maps to schema.org/image
    /// </summary>
    [Url]
    [MaxLength(255)]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets additional URLs for the item's images.
    /// Maps to schema.org/additionalProperty with value as schema.org/ImageObject
    /// </summary>
    [MaxLength(1000)]
    public string AdditionalImages { get; set; }

    /// <summary>
    /// Gets or sets the weight of the item.
    /// Maps to schema.org/weight
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// Gets or sets the weight unit (e.g., kg, lb).
    /// Maps to schema.org/weightUnit
    /// </summary>
    [MaxLength(10)]
    public string WeightUnit { get; set; }

    /// <summary>
    /// Gets or sets the height of the item.
    /// Maps to schema.org/height
    /// </summary>
    public decimal? Height { get; set; }

    /// <summary>
    /// Gets or sets the width of the item.
    /// Maps to schema.org/width
    /// </summary>
    public decimal? Width { get; set; }

    /// <summary>
    /// Gets or sets the depth of the item.
    /// Maps to schema.org/depth
    /// </summary>
    public decimal? Depth { get; set; }

    /// <summary>
    /// Gets or sets the dimensions unit (e.g., cm, in).
    /// </summary>
    [MaxLength(10)]
    public string DimensionsUnit { get; set; }

    /// <summary>
    /// Gets or sets the color of the item.
    /// Maps to schema.org/color
    /// </summary>
    [MaxLength(50)]
    public string Color { get; set; }

    /// <summary>
    /// Gets or sets the item's material.
    /// Maps to schema.org/material
    /// </summary>
    [MaxLength(100)]
    public string Material { get; set; }

    /// <summary>
    /// Gets or sets the item's country of origin.
    /// Maps to schema.org/countryOfOrigin
    /// </summary>
    [MaxLength(100)]
    public string CountryOfOrigin { get; set; }
}
