using System.Collections.Generic;
using System.Linq;

namespace  PaymentContext.Domaint.Entities
{
  public class Student
  {
      private IList<Subscription> _subscriptions;
      public Student(string firstName, string lastName, string document, string email)
      {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
      }

      public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{ return _subscriptions.ToArray();}}

        public void AddSubscriptions(Subscription subscription)
        {
          //cancela todas as assinaturas e coloca essa como principal
          foreach (var sub in _subscriptions) 
          {
            DeactivateSubscription(subscription);
          }
          _subscriptions.Add(subscription);
        }

      private void DeactivateSubscription(Subscription sub)
      {
        sub.Active = false;
      }
  }
}