
using System;
using PaymentContext.Domain.ValueObjects;

namespace  PaymentContext.Domain.Entities
{
  public class CreditCardPayment : Payment
  {
    public string CardHolderName { get; set; }
    public string CardNumber { get; set; }
    public string LastTransactionNumber { get; set; }

    public CreditCardPayment(string cardHolderName, string cardNumber,
     string lastTransactionNumber, string number,
      DateTime paidDate, DateTime expireDate,
      decimal total, decimal totalPaid, string payer,
      Document document, Email email, Adress adress) 
      : base( number,
        paidDate,
        expireDate, 
        total,
        totalPaid,
        payer,
        document,
        email,
        adress)
    {
      CardHolderName = cardHolderName;
      CardNumber = cardNumber;
      LastTransactionNumber = lastTransactionNumber;
    }
  }
}