namespace BaseCompany.ErpModel.Enums;

/// <summary>
/// Represents types of customers in the system.
/// </summary>
public enum CustomerType
{
    /// <summary>
    /// An individual person.
    /// </summary>
    Individual = 1,
    
    /// <summary>
    /// A company or business entity.
    /// </summary>
    Company = 2,
    
    /// <summary>
    /// A government entity.
    /// </summary>
    Government = 3,
    
    /// <summary>
    /// A non-profit organization.
    /// </summary>
    NonProfit = 4,
    
    /// <summary>
    /// A distributor or reseller.
    /// </summary>
    Distributor = 5,
    
    /// <summary>
    /// An educational institution.
    /// </summary>
    Educational = 6
}