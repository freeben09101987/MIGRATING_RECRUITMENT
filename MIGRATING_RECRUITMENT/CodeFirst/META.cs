namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("META")]
    public partial class META
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_INP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DT_CHG { get; set; }
    }
}
