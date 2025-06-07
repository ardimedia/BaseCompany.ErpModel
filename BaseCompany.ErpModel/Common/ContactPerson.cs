using BaseCompany.ErpModel.Base;
using System;

namespace BaseCompany.ErpModel.Common;

/// <summary>
/// Represents a contact person for an organization or entity.
/// </summary>
public class ContactPerson : AuditableEntity
{
    /// <summary>
    /// Gets or sets the contact person's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the contact person's email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the contact person's phone number.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the contact person's designation or role.
    /// </summary>
    public string Designation { get; set; }
}
