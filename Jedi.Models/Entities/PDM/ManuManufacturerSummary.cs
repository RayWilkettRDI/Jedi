using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("manuManufacturerSummary")]
    public partial class ManuManufacturerSummary
    {
        [Key]
        [Column("PKID", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(128)]
        public string ManufacturerName { get; set; }
        [Required]
        [StringLength(50)]
        public string StreetAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string StateProvince { get; set; }
        [StringLength(50)]
        public string PostalCode { get; set; }
        [Column("CountryID")]
        public int CountryId { get; set; }
        [Column("VendorID")]
        public int VendorId { get; set; }
    }
}
