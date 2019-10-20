namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
      public string Adress { get; private set; }

    public Email(string adress)
    {
      Adress = adress;
    }
  }
}