using MOD.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Repositories
{
    public interface IPaymentRep
    {
        Payment Add(Payment item);
        IEnumerable<Custom1> GetPayments();
        IEnumerable<Custom> GetPaymentsByMentorId(int id);
    }
}
