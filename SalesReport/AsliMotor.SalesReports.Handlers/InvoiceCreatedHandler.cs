using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsliMotor.Invoices.Events;
using NServiceBus;

namespace AsliMotor.SalesReports.Handlers
{
    public class InvoiceCreatedHandler:IMessageHandler<InvoiceCreated>
    {
        public void Handle(InvoiceCreated message)
        {
            var a = "a";
        }
    }
}
