using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
      public string Number { get; private set; }
      public EDocumentType Type { get; private set; }
    public Document(string Number, EDocumentType type)
    {
      this.Number = Number;
      Type = type;
    }
  }
}