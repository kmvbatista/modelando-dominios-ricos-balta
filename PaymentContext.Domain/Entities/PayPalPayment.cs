using System;
using PaymentContext.Domain.ValueObjects;

namespace  PaymentContext.Domain.Entities
{
  public class PayPalPayment : Payment
  {
    public string TriansactionCode { get; private set; }

    public PayPalPayment(string triansactionCode,
      DateTime paidDate, DateTime expireDate,
       decimal total, decimal totalPaid, string payer,
        Document document, Email email, Adress adress) : base( paidDate,  expireDate,  total,  totalPaid,  payer,  document,  email,  adress)
    {
      TriansactionCode = triansactionCode;
    }
  }
}