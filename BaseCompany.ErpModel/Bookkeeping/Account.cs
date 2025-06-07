using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.Bookkeeping;

/// <summary>
/// Represents an account in the chart of accounts.
/// </summary>
public class Account : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public AccountType Type { get; set; }
}
