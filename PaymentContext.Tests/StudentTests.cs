using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domaint.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            Student student = new Student("Kennedy", "Batista", "14832124676", "kennedymessias.vb@gmail.com");
        }
    }
}
