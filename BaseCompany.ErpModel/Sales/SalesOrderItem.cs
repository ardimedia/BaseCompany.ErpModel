using CompanyName.ERPNext.Entities.Base;
using CompanyName.ERPNext.Entities.Sales;
using CompanyName.ERPNext.Entities.Inventory;
using System;
using System.Collections.Generic;

namespace CompanyName.ERPNext.Entities.Sales;

/// <summary>
/// Represents an individual item within a sales order.
/// </summary>
public class SalesOrderItem : AuditableEntity
{
    public Guid SalesOrderId { get; set; }
    public SalesOrder SalesOrder { get; set; }
    public Guid ItemId { get; set; }
    public Item Item { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
}
