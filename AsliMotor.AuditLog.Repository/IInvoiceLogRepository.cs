using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsliMotor.AuditLog.Repository
{
    public interface IInvoiceLogRepository
    {
        long GetLastAngsuran(Guid id);
    }
}
