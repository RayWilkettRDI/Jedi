using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("URLSource")]
    public partial class Urlsource
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? PubToSupplierPortal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InactiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UploadDate { get; set; }
        public bool? ExpireDateNotify { get; set; }
        public int? ExpireDateNotifyNumDays { get; set; }
        [Column("URLPath")]
        [StringLength(2000)]
        public string Urlpath { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public bool? IsProprietary { get; set; }
        public int? Version { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fkEntity", TypeName = "char(40)")]
        public string FkEntity { get; set; }
        public bool? NotifyPrior { get; set; }
        public int? NotifyPriorDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkSupplierOwner", TypeName = "char(40)")]
        public string FkSupplierOwner { get; set; }
    }
}
