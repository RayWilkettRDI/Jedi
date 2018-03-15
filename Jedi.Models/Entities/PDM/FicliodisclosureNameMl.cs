using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FICLIODisclosureNameML")]
    public partial class FicliodisclosureNameMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Column("fkFICLIODisclosure", TypeName = "char(40)")]
        public string FkFicliodisclosure { get; set; }
    }
}
