using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Models
{
    [Table("ProductAudit9")]
    public partial class ProductAudit9
    {
        [Key]
        [Column("AuditID")]
        public int AuditId { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        public int UnitPriceBefore { get; set; }
        public int UnitPriceAfter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AuditDate { get; set; }
        [StringLength(128)]
        public string ChangeUser { get; set; } = null!;
    }
}
