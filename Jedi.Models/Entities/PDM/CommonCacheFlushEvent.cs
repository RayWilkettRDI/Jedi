using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonCacheFlushEvent")]
    public partial class CommonCacheFlushEvent
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("cacheName")]
        [StringLength(25)]
        public string CacheName { get; set; }
        [Column("appName")]
        [StringLength(36)]
        public string AppName { get; set; }
        [Column("message")]
        [StringLength(1024)]
        public string Message { get; set; }
        [Column("serverName")]
        [StringLength(100)]
        public string ServerName { get; set; }
        [Column("timeFlushed", TypeName = "datetime")]
        public DateTime? TimeFlushed { get; set; }
        [Column("correlationId", TypeName = "char(36)")]
        public string CorrelationId { get; set; }
    }
}
