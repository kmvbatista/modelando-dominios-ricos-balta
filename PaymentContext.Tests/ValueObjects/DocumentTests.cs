using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        //[TestMethod]
        public void ErrorWhenCnpjIsInvalid()
        {
          var doc = new Document("1234", Domain.Enums.EDocumentType.CNPJ);
          Assert.IsTrue(doc.Invalid);
        }
        //[TestMethod]
        public void SuccesWhenCnpjIsValid() {
          var doc = new Document("83630597000185", Domain.Enums.EDocumentType.CNPJ);
          Assert.IsTrue(doc.Valid);
        }
        //[TestMethod]
        public void SuccesWhenCPFIsValid() {
          var doc = new Document("123", Domain.Enums.EDocumentType.CPF);
          Assert.IsTrue(doc.Invalid);
        }
        //[TestMethod]
        public void ErrorWhenCPFIsInvalid() {
          var doc = new Document("14832122676", Domain.Enums.EDocumentType.CPF);
          Assert.IsTrue(doc.Valid);
        }
    }
}
