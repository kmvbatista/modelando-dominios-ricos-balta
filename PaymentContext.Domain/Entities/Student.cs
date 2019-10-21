using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace  PaymentContext.Domain.Entities
{
  public class Student : Entity
  {
      private IList<Subscription> _subscriptions;
      public Student(Name name, Document document, Email email)
      {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>() ;
        AddNotifications(name, document, email);
      }
      public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{ return _subscriptions.ToArray();}}

        public void AddSubscriptions(Subscription subscription)
        {
          bool hasSubscriptions = false;
          //cancela todas as assinaturas e coloca essa como principal
          foreach (var sub in _subscriptions) 
          {
            if(sub.Active) {
              hasSubscriptions = true;
              break;
            }
          }
          AddNotifications(   
            new Contract()
            .Requires()
            .IsFalse(hasSubscriptions ,"Student.Subscriptions", "Você já tem uma assinatura ativa")
            .IsGreaterThan(subscription.Payments.Count, 0, "Student.Subscription.Payments", 
            "Essa assinatura não contém pagamentos")
          );
          _subscriptions.Add(subscription);
        }

      // private void DeactivateSubscription(Subscription sub)
      // {
      //   sub.Deactivate();
      // }
  }
}