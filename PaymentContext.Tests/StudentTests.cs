using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using System;
namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student _student;
        private readonly Subscription _subscription;
        private readonly Name _name;
        private readonly Document _document;
        private readonly Adress _address;
        private readonly Email _email;
        private readonly Payment _payment;

    public StudentTests()
    {
      var name = new Name("Bruce", "Wayne");
            _document = new Document("14832124676", Domain.Enums.EDocumentType.CPF);
            _email = new Email("Batman@dc.com");
            _address = new Adress("rua caca", "12345", "passo manso", "hakcaton",
            "Santa","Brasil", "39650-000");
        _payment = new PayPalPayment("1234578",DateTime.Now, DateTime.Now.AddDays(3),
            3888, 3888, "  bruce ", _document, _email, _address);
      _student =new Student(name, _document, _email);
      _subscription = new Subscription(null);
    }

    [TestMethod]
        public void ErrorWhenActiveSubscriptions() {
            _subscription.AddPayments(_payment);
            _student.AddSubscriptions(_subscription);
            Assert.IsTrue(_student.Valid);
        }
        [TestMethod]
        public void ErrorWhenSubscriptionsHasNoPayments() {
            _student.AddSubscriptions(_subscription);
            Assert.IsTrue(_student.Invalid);
        }
        [TestMethod]
        public void SuccessWhenNoSubscriptions() {
            _student.AddSubscriptions(_subscription);
            Assert.IsTrue(_student.Invalid);
        }
    }
}
