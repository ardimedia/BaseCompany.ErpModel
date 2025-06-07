namespace BaseCompany.ErpModel.Bookkeeping;

/// <summary>
/// Represents a debit or credit line in a journal entry.
/// </summary>
public class JournalEntryLine
{
    public Guid Id { get; set; }
    public Account Account { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public string? Description { get; set; }
}