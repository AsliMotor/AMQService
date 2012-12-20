using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonaStoco.Inf.DataMapper;
using AsliMotor.AuditLog.Repository.models;

namespace AsliMotor.AuditLog.Repository
{
    public class InvoiceLogRepository : IInvoiceLogRepository
    {
        public IQueryObjectMapper QueryObjectMapper { get; set; }
        public InvoiceLogRepository()
        {
        }
        public long GetLastAngsuran(Guid id)
        {
            return QueryObjectMapper.Map<LastAngsuran>("getLastAngsuran", new string[] { "invoiceid" }, new object[] { id }).FirstOrDefault().LastAngsuranBulanan;
        }
    }
}
