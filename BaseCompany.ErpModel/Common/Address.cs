using BaseCompany.ErpModel.Base;
using System.Collections.Generic;

namespace BaseCompany.ErpModel.Common;

/// <summary>
/// Represents a physical or mailing address.
/// Maps to schema.org/PostalAddress concept.
/// </summary>
public class Address : AuditableEntity
{
    /// <summary>
    /// Gets or sets the street address.
    /// Maps to schema.org/streetAddress
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// Maps to schema.org/addressLocality
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the state or province.
    /// Maps to schema.org/addressRegion
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// Maps to schema.org/postalCode
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// Maps to schema.org/addressCountry
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the name of the address recipient.
    /// Maps to schema.org/name
    /// </summary>
    public string AddressName { get; set; }

    /// <summary>
    /// Gets or sets the post office box number.
    /// Maps to schema.org/postOfficeBoxNumber
    /// </summary>
    public string POBox { get; set; }

    /// <summary>
    /// Gets or sets a type of the address (e.g., Home, Work, Billing, Shipping).
    /// Maps to schema.org/contactType
    /// </summary>
    public string AddressType { get; set; }

    /// <summary>
    /// Gets or sets the address in a format suitable for display.
    /// Maps to schema.org/alternateName
    /// </summary>
    public string FormattedAddress { get; set; }

    /// <summary>
    /// Gets or sets geographical coordinates for the address.
    /// Maps to schema.org/geo
    /// </summary>
    public string GeoCoordinates { get; set; }

    /// <summary>
    /// Gets or sets whether this is a default address.
    /// </summary>
    public bool IsDefaultAddress { get; set; }
}
