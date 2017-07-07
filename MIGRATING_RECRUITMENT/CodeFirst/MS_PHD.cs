namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MS_PHD
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        [StringLength(10)]
        public string COURSE { get; set; }

        [StringLength(20)]
        public string SEMESTER { get; set; }

        [StringLength(4)]
        public string YR { get; set; }
    }
}
