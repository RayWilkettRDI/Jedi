using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("attachments")]
    public partial class Attachments
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Required]
        [Column("filename")]
        [StringLength(128)]
        public string Filename { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("filesize")]
        public int Filesize { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UploadDate { get; set; }
        public int? ExpireDateNotifyNumDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InactiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        public bool? PubToSupplierPortal { get; set; }
        public bool? ExpireDateNotify { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public bool? IsProprietary { get; set; }
        [Column("fkSupplierOwner", TypeName = "char(40)")]
        public string FkSupplierOwner { get; set; }
    }
}
