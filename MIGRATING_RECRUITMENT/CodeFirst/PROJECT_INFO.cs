namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROJECT_INFO
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        [StringLength(120)]
        public string TITLE { get; set; }

        [StringLength(25)]
        public string PROJECTNO { get; set; }

        [StringLength(3)]
        public string PTYPE { get; set; }

        [StringLength(4)]
        public string SPON { get; set; }

        [StringLength(4)]
        public string COOR { get; set; }

        [StringLength(60)]
        public string COO { get; set; }
    }
}
