using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("scrmContact")]
    public partial class ScrmContact
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string CellPage { get; set; }
        [Column("firstname")]
        [StringLength(100)]
        public string Firstname { get; set; }
        [Column("emergencycontact")]
        public bool? Emergencycontact { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        [Column("lastname")]
        [StringLength(100)]
        public string Lastname { get; set; }
        [StringLength(600)]
        public string Description { get; set; }
        [Column("fkentity", TypeName = "char(40)")]
        public string Fkentity { get; set; }
        [StringLength(100)]
        public string JobTitle { get; set; }
        [Column("fkcategory", TypeName = "char(40)")]
        public string Fkcategory { get; set; }
        [Column("fax")]
        [StringLength(50)]
        public string Fax { get; set; }
        [Column("phone")]
        [StringLength(100)]
        public string Phone { get; set; }
        public bool? PubToSupplierPortal { get; set; }
        public bool? VendorHasApproved { get; set; }
        [Column("emergencyContactNumber")]
        [StringLength(50)]
        public string EmergencyContactNumber { get; set; }
        [Column("RepPKID", TypeName = "char(40)")]
        public string RepPkid { get; set; }
    }
}
