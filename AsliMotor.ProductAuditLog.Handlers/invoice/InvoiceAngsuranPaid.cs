using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsliMotor.Invoices.Events;
using NServiceBus;
using BonaStoco.Inf.Reporting;
using AsliMotor.AuditLog.Models;
using AsliMotor.AuditLog.Repository;

namespace AsliMotor.AuditLog.Handlers
{
    public class InvoiceAngsuranPaid : IMessageHandler<AngsuranPaid>
    {
        public IReportingRepository ReportingRepository { get; set; }
        public IInvoiceLogRepository InvoiceLogRepository { get; set; }
        public void Handle(AngsuranPaid message)
        {
            ReportingRepository.Save<InvoiceLog>(
                new InvoiceLog()
                {
                    Id = Guid.NewGuid(),
                    BranchId = message.Payload.BranchId,
                    Payload = Newtonsoft.Json.JsonConvert.SerializeObject(message.Payload),
                    Receive = InvoiceLogRepository.GetLastAngsuran(message.Payload.id) + 1,
                    DateTime = message.Datetime,
                    UserName = message.Username,
                    InvoiceId = message.Payload.id,
                    Action = (int)InvoiceAction.AngsuranPaid
                });
        }
    }
}
