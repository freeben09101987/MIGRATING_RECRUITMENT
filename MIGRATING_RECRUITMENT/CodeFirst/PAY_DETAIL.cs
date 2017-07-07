namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAY_DETAIL
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        public double? BAISC { get; set; }

        public double? INCR { get; set; }

        public double? HRA { get; set; }

        [StringLength(4)]
        public string PAYBILL_ID { get; set; }

        [StringLength(5)]
        public string PAYBILL_NO { get; set; }
    }
}
