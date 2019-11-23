using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Context;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repositories
{
    


    public class PaymentRep : IPaymentRep
    {
        PaymentContext _context;

        public PaymentRep(PaymentContext paymentContext)
        {
            _context=paymentContext;
        }
        public Payment Add(Payment item)
        {
            _context.Payments.Add(item);
            _context.SaveChanges();
            return item;
        }

        public IEnumerable<Custom1> GetPayments()
        {
            //return _context.Payments;
            return (from p in _context.Payments
                    join t in _context.Trainings on
                    p.TrainingID equals t.TrainingID
                    select new Custom1()
                    {
                        UserID = p.UID,
                        TechnologyName = t.TechnologyName,
                        StartDate = t.StartDate,
                        EndDate = t.EndDate,
                        Mentor_Amount = p.Mentor_Amount,
                        Amount=p.Amount,
                        MentorID=p.MentorID
                    }).ToList();
        }

        public IEnumerable<Custom> GetPaymentsByMentorId(int id)
        {
            return (from p in _context.Payments
                    join t in _context.Trainings on
                    p.TrainingID equals t.TrainingID 
                    where p.MentorID ==id
                    select new Custom()
                    {
                        UserID = p.UID,
                        TechnologyName = t.TechnologyName,
                        StartDate = t.StartDate,
                        EndDate = t.EndDate,
                        Mentor_Amount = p.Mentor_Amount
                    }).ToList();
        }
    }
}
