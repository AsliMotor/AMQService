using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsliMotor.AuditLog.Models
{
    public enum InvoiceAction : int
    {
        InvoiceCreated,
        AngsuranPaid,
        DueDateChanged,
        LamaAngsuranChanged,
        PaymentTypeChanged,
        SukuBungaChanged,
        UangAngsuranChanged,
        UangMukaChanged,
        InvoiceCanceled,
        InvoicePulled,
        ProductChanged,
        CustomerChanged,
        PriceChanged,
        TermChanged
    }
}
