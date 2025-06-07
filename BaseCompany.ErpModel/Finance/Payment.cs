using CompanyName.ERPNext.Entities.Base;
using System;

namespace CompanyName.ERPNext.Entities.Finance;

/// <summary>
/// Represents a payment made for a sales or purchase order.
/// </summary>
public class Payment : AuditableEntity
{
    /// <summary>
    /// Gets or sets the payment amount.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets or sets the payment date.
    /// </summary>
    public DateTime PaymentDate { get; set; }

    /// <summary>
    /// Gets or sets the payment method (e.g., Bank Transfer, Cash, Credit Card).
    /// </summary>
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Gets or sets the reference to the related sales order, if any.
    /// </summary>
    public Guid? SalesOrderId { get; set; }

    /// <summary>
    /// Gets or sets the related sales order.
    /// </summary>
    public Sales.SalesOrder SalesOrder { get; set; }

    /// <summary>
    /// Gets or sets the reference to the related purchase order, if any.
    /// </summary>
    public Guid? PurchaseOrderId { get; set; }

    /// <summary>
    /// Gets or sets the related purchase order.
    /// </summary>
    public Purchase.PurchaseOrder PurchaseOrder { get; set; }
}
