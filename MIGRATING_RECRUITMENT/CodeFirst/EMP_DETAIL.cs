namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMP_DETAIL
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        [StringLength(1)]
        public string STAT { get; set; }

        [StringLength(7)]
        public string DEPT { get; set; }

        [StringLength(3)]
        public string DESIG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DTAP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EXTN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DRLF { get; set; }

        [StringLength(6)]
        public string OLD_FILENO { get; set; }

        [StringLength(35)]
        public string DESIGN { get; set; }

        [StringLength(50)]
        public string DEPARTMENT { get; set; }

        public DateTime? EXTN_DATE { get; set; }
    }
}
