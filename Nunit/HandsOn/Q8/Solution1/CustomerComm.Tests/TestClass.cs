using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerCommLib;
using Moq;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SMTPServiceTests()
        {
            var smtpClient = new Mock<IMailSender>();
            smtpClient.Setup(x => x.SendMail("CTS20DN013@gmail.com", "Welcome User")).Returns(true);
            CustomerCommLib.CustomerComm component = new CustomerCommLib.CustomerComm(smtpClient.Object);
            Assert.AreEqual(true, component.SendMailToCustomer());
        }
    }
}
