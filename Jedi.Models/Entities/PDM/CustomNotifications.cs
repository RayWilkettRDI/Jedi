using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("customNotifications")]
    public partial class CustomNotifications
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Required]
        [Column("message")]
        [StringLength(2048)]
        public string Message { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column("starts", TypeName = "datetime")]
        public DateTime? Starts { get; set; }
        [Column("expires", TypeName = "datetime")]
        public DateTime? Expires { get; set; }
        [StringLength(1024)]
        public string NotificationContext { get; set; }
    }
}
