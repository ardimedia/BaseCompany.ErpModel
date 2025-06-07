namespace CompanyName.ERPNext.Entities.Enums;

/// <summary>
/// Represents the types of items in the inventory system.
/// </summary>
public enum ItemType
{
    /// <summary>
    /// Inventory items that are stocked and tracked.
    /// </summary>
    Inventory = 1,
    
    /// <summary>
    /// Consumable items that are used in operations but not tracked.
    /// </summary>
    Consumable = 2,
    
    /// <summary>
    /// Services provided to customers.
    /// </summary>
    Service = 3,
    
    /// <summary>
    /// Fixed assets owned by the company.
    /// </summary>
    FixedAsset = 4,
    
    /// <summary>
    /// Digital products that can be sold and delivered electronically.
    /// </summary>
    Digital = 5,
    
    /// <summary>
    /// Products that are assembled from other inventory items.
    /// </summary>
    Assembly = 6
}