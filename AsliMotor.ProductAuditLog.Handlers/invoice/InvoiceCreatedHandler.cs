using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsliMotor.Invoices.Events;
using NServiceBus;
using BonaStoco.Inf.Reporting;
using AsliMotor.AuditLog.Models;

namespace AsliMotor.AuditLog.Handlers
{
    public class InvoiceCreatedHandler : IMessageHandler<InvoiceCreated>
    {
        public IReportingRepository ReportingRepository { get; set; }
        public void Handle(InvoiceCreated message)
        {
            ReportingRepository.Save<InvoiceLog>(
                new InvoiceLog()
                {
                    Id = Guid.NewGuid(),
                    InvoiceId = message.Payload.id,
                    BranchId = message.Payload.BranchId,
                    Payload = Newtonsoft.Json.JsonConvert.SerializeObject(message.Payload),
                    Receive = 0,
                    DateTime = message.Datetime,
                    UserName = message.Username,
                    Action = (int) InvoiceAction.InvoiceCreated
                });
        }
    }
}
