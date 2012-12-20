using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsliMotor.AuditLog.Models
{
    public enum Events : int
    {
        Created = 0,
        Edited = 1,
        Removed = 2,
        PriceChanged = 3
    }
}
