using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Shared.Entities;

namespace  PaymentContext.Domain.Entities
{
  public class Subscription : Entity
  {
    private IList<Payment> _payments;
    public Subscription(DateTime? expireDate)
    {
      CreationDate = DateTime.Now;
      LastUpdateDate = DateTime.Now;
      Active = true;
      ExpireDate = expireDate;
      _payments = new List<Payment>();
    }

    public DateTime CreationDate { get;  private set; }
      public DateTime LastUpdateDate { get;  private set; }
      public DateTime? ExpireDate { get;  private set; }
      public bool Active { get; private set; }
      public IReadOnlyCollection<Payment> Payments { get; set; }

      public void AddPayments(Payment payment) 
      {
        _payments.Add(payment);
      }
      public void Activate() 
      {
        Active = true;
        LastUpdateDate = DateTime.Now;
      }
      public void Deactivate() 
      {
        Active = false;
        LastUpdateDate = DateTime.Now;
      }
    }
}