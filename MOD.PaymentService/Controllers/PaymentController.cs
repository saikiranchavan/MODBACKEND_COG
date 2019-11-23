using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.PaymentService.Models;
using MOD.PaymentService.Repositories;

namespace MOD.PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        IPaymentRep repositories;
        public PaymentController(IPaymentRep rep)
        {
            repositories = rep;
        }
        // GET: api/Payment
        [HttpGet]
        [Route("GetAllPayment")]
        public IEnumerable<Custom1> Get()
        {
            return repositories.GetPayments();
        }

        [HttpGet("{id}")]
        [Route("GetAllPaymentByMentorId/{id}")]
        public IEnumerable<Custom> Get(int id)
        {
            return repositories.GetPaymentsByMentorId(id);
        }

        // POST: api/Payment
        [HttpPost("{item}")]
        [Route("AddPayment/{item}")]
        public Payment Post(Payment item)
        {
           return repositories.Add(item);

        }

        // PUT: api/Payment/5
        [HttpPut("{id}")]
        [Route("UpdatePayment/{item}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
