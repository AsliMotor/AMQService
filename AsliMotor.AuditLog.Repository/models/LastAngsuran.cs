using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonaStoco.Inf.Data.ViewModel;

namespace AsliMotor.AuditLog.Repository.models
{
    [NamedSqlQuery("getLastAngsuran", @"select max(receive) as LastAngsuranBulanan from invoicelog where invoiceid = @invoiceid")]
    public class LastAngsuran:IViewModel
    {
        public long LastAngsuranBulanan { get; set; }
    }
}
