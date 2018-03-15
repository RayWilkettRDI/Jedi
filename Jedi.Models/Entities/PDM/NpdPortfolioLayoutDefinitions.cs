using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdPortfolioLayoutDefinitions")]
    public partial class NpdPortfolioLayoutDefinitions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("isMarkedAsDeleted")]
        public bool? IsMarkedAsDeleted { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
