namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONAL_INFO
    {
        [Key]
        [StringLength(6)]
        public string FILENO { get; set; }

        [StringLength(150)]
        public string NAME { get; set; }

        [StringLength(2)]
        public string SCSTOS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string FATHER { get; set; }

        [StringLength(30)]
        public string ADDRESS1 { get; set; }

        [StringLength(30)]
        public string ADDRESS2 { get; set; }

        [StringLength(30)]
        public string ADDRESS3 { get; set; }

        [StringLength(30)]
        public string ADDRESS4 { get; set; }

        [StringLength(20)]
        public string CITY { get; set; }

        [StringLength(1)]
        public string SEX { get; set; }

        [StringLength(3)]
        public string BLDGRP { get; set; }

        [StringLength(3)]
        public string RH { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(30)]
        public string R_ADDR1 { get; set; }

        [StringLength(30)]
        public string R_ADDR2 { get; set; }

        [StringLength(20)]
        public string R_CITY { get; set; }

        [StringLength(7)]
        public string R_PIN { get; set; }

        [StringLength(12)]
        public string R_PHONE { get; set; }

        [StringLength(30)]
        public string R_ADDR3 { get; set; }

        [StringLength(30)]
        public string R_ADDR4 { get; set; }

        [StringLength(50)]
        public string EMAIL_ID { get; set; }

        [StringLength(3)]
        public string PENSIONER { get; set; }

        [StringLength(50)]
        public string QUALIFICATION { get; set; }
    }
}
