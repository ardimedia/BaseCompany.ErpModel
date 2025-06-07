using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.Bookkeeping;

/// <summary>
/// Represents a journal entry consisting of multiple debit and credit lines.
/// </summary>
public class JournalEntry : AuditableEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset EntryDate { get; set; }
    public string Reference { get; set; } = string.Empty;
    public List<JournalEntryLine> Lines { get; set; } = new();
    public string SourceDocumentType { get; set; } // "SalesOrder", "PurchaseOrder", etc.
    public Guid? SourceDocumentId { get; set; }    // Reference to the source document
}