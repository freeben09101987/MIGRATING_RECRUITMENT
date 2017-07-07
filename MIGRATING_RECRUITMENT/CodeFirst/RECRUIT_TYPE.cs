namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECRUIT_TYPE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string FILENO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TYPE { get; set; }
    }
}
