using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsliMotor.Invoices.Events;
using NServiceBus;
using BonaStoco.Inf.Reporting;
using AsliMotor.AuditLog.Models;
using AsliMotor.AuditLog.Repository;

namespace AsliMotor.AuditLog.Handlers.invoice
{
    public class InvoiceTermChanged : IMessageHandler<TermChanged>
    {
        public IReportingRepository ReportingRepository { get; set; }
        public IInvoiceLogRepository InvoiceLogRepository { get; set; }
        public void Handle(TermChanged message)
        {
            ReportingRepository.Save<InvoiceLog>(
                new InvoiceLog()
                {
                    Id = Guid.NewGuid(),
                    InvoiceId = message.Payload.id,
                    BranchId = message.Payload.BranchId,
                    Payload = Newtonsoft.Json.JsonConvert.SerializeObject(message.Payload),
                    Receive = InvoiceLogRepository.GetLastAngsuran(message.Payload.id),
                    DateTime = message.DateTime,
                    UserName = message.Username,
                    Action = (int)InvoiceAction.TermChanged
                });
        }
    }
}
