namespace CompanyName.ERPNext.Entities.Enums;

/// <summary>
/// Represents the status of an order in the system.
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Order is drafted but not yet submitted.
    /// </summary>
    Draft = 1,
    
    /// <summary>
    /// Order has been submitted and is awaiting processing.
    /// </summary>
    Submitted = 2,
    
    /// <summary>
    /// Order has been processed and is in progress.
    /// </summary>
    InProgress = 3,
    
    /// <summary>
    /// Order has items on backorder.
    /// </summary>
    PartiallyFulfilled = 4,
    
    /// <summary>
    /// Order has been fulfilled and is pending delivery.
    /// </summary>
    Fulfilled = 5,
    
    /// <summary>
    /// Order has been delivered to the customer.
    /// </summary>
    Delivered = 6,
    
    /// <summary>
    /// Order has been completed and all requirements have been met.
    /// </summary>
    Completed = 7,
    
    /// <summary>
    /// Order has been cancelled.
    /// </summary>
    Cancelled = 8
}