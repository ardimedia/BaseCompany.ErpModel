using CompanyName.ERPNext.Entities.Base;
using System.Collections.Generic;

namespace CompanyName.ERPNext.Entities.Common;

/// <summary>
/// Represents a physical or mailing address.
/// </summary>
public class Address : AuditableEntity
{
    /// <summary>
    /// Gets or sets the street address.
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the state or province.
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    public string Country { get; set; }
}
