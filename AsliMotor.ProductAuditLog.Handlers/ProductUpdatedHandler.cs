using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using AsliMotor.Products.Events;
using BonaStoco.Inf.Reporting;
using AsliMotor.AuditLog.Models;

namespace AsliMotor.AuditLog.Handlers
{
    public class ProductUpdatedHandler:IMessageHandler<ProductChanged>
    {
        public IReportingRepository ReportingRepository { get; set; }
        public void Handle(ProductChanged message)
        {
            ReportingRepository.Save<ProductLog>(new ProductLog()
            {
                id = Guid.NewGuid(),
                Action = (int)Events.Edited,
                Username = message.UserName,
                Datetime = DateTime.Now.ToString("dd-mm-yyyy hh:mm:ss"),
                BranchId = message.Payload.BranchId,
                HargaBeli = message.Payload.HargaBeli,
                Merk = message.Payload.Merk,
                NoBpkb = message.Payload.NoBpkb,
                NoMesin = message.Payload.NoMesin,
                NoPolisi = message.Payload.NoPolisi,
                NoRangka = message.Payload.NoRangka,
                ProductId = message.Payload.id,
                Status = message.Payload.Status,
                Tahun = message.Payload.Tahun,
                Type = message.Payload.Type,
                Warna = message.Payload.Warna
            });
        }
    }
}
