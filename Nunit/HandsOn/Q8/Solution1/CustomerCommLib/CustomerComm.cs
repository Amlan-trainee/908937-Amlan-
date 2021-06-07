using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm
    {
        IMailSender _mailSender;
        public CustomerComm()
        { }

        public CustomerComm(IMailSender mailSender)
        {
            this._mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("abcd@gmal.com", "Hallo User");
            return true;
        }
    }
    public class Customer
    {
        CustomerComm cc = new CustomerComm();
    }
}
