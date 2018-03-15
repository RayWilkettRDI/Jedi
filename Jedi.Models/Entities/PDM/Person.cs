using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Person
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("first_name", TypeName = "char(30)")]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name", TypeName = "char(30)")]
        public string LastName { get; set; }
    }
}
