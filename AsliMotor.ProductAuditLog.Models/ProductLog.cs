using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonaStoco.Inf.Data.ViewModel;

namespace AsliMotor.AuditLog.Models
{
    public class ProductLog : IViewModel
    {
        public Guid id { get; set; }
        public string Username { get; set; }
        public string Datetime { get; set; }
        public int Action { get; set; }
        public Guid ProductId { get; set; }
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Tahun { get; set; }
        public string Warna { get; set; }
        public string NoRangka { get; set; }
        public string NoMesin { get; set; }
        public string NoBpkb { get; set; }
        public string NoPolisi { get; set; }
        public decimal HargaBeli { get; set; }
        public string Status { get; set; }
        public string BranchId { get; set; }
    }
}
