using System;
using System.Collections.Generic;
using System.Linq;
namespace  PaymentContext.Domaint.Entities
{
  public class Subscription
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
      public bool Active { get; set; }
      public IReadOnlyCollection<Payment> Payments { get; set; }

      public void AddPayments() 
      {

      }
    }
}