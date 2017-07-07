namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADDITIONAL_INFO
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DINC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LDINC { get; set; }

        [StringLength(20)]
        public string REM { get; set; }

        [StringLength(1)]
        public string PFLAG { get; set; }

        [StringLength(30)]
        public string PCODE { get; set; }

        public double? MONTH { get; set; }

        public double? RATE { get; set; }

        [StringLength(50)]
        public string PROVISIONAL { get; set; }

        [StringLength(10)]
        public string MEDICAL { get; set; }
    }
}
