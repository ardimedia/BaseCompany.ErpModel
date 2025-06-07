using CompanyName.ERPNext.Entities.Base;
using CompanyName.ERPNext.Entities.Enums;
using CompanyName.ERPNext.Entities.Sales;
using CompanyName.ERPNext.Entities.Purchase;

namespace CompanyName.ERPNext.Entities.Inventory;

/// <summary>
/// Represents an item or product available for sale or purchase.
/// </summary>
public class Item : AuditableEntity
{
    /// <summary>
    /// Gets or sets the unique item code.
    /// </summary>
    [Required(ErrorMessage = "Item code is required")]
    [MaxLength(50)]
    public string ItemCode { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    [Required(ErrorMessage = "Item name is required")]
    [MaxLength(100)]
    public string ItemName { get; set; }
    
    /// <summary>
    /// Gets or sets the type of item.
    /// </summary>
    [Required]
    public ItemType ItemType { get; set; } = ItemType.Inventory;
    
    /// <summary>
    /// Gets or sets the description of the item.
    /// </summary>
    [MaxLength(1000)]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or sets the unit of measure for the item.
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string UnitOfMeasure { get; set; }
    
    /// <summary>
    /// Gets or sets the standard selling price of the item.
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
    public decimal StandardSellingPrice { get; set; }
    
    /// <summary>
    /// Gets or sets the standard buying price of the item.
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
}
