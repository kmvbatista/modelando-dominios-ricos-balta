 using System;
using PaymentContext.Domain.ValueObjects;

namespace  PaymentContext.Domain.Entities
{
  public class BoletoPayment : Payment
  {
      public string Barcode { get; private set; }
      public string BoletoNumber { get; private set; }

    public BoletoPayment(string barcode,
     string boletoNumber, string number,
      DateTime paidDate, DateTime expireDate,
       decimal total, decimal totalPaid, string payer,
        Document document, Email email, Adress adress) : base( paidDate,  expireDate,  total,  totalPaid,  payer,  document,  email,  adress)
    {
      Barcode = barcode;
      BoletoNumber = boletoNumber;
    }
  }
}
 