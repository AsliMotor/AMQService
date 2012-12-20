using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonaStoco.Inf.Data.ViewModel;

namespace AsliMotor.AuditLog.Models
{
    public class InvoiceLog : IViewModel
    {
        public Guid Id { get; set; }
        public string Payload { get; set; }
        public DateTime DateTime { get; set; }
        public string BranchId { get; set; }
        public long Receive { get; set; }
        public string UserName { get; set; }
        public Guid InvoiceId { get; set; }
        public int Action { get; set; }
    }
}
