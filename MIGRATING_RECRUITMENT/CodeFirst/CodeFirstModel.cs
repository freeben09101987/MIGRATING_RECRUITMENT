namespace MIGRATING_RECRUITMENT.CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CodeFirstModel : DbContext
    {
        public CodeFirstModel()
            : base("name=CodeFirstModel")
        {
        }

        public virtual DbSet<ADDITIONAL_INFO> ADDITIONAL_INFO { get; set; }
        public virtual DbSet<EMP_DETAIL> EMP_DETAIL { get; set; }
        public virtual DbSet<META> METAs { get; set; }
        public virtual DbSet<MS_PHD> MS_PHD { get; set; }
        public virtual DbSet<PAY_DETAIL> PAY_DETAIL { get; set; }
        public virtual DbSet<PERSONAL_INFO> PERSONAL_INFO { get; set; }
        public virtual DbSet<PROJECT_INFO> PROJECT_INFO { get; set; }
        public virtual DbSet<RECRUIT_TYPE> RECRUIT_TYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MS_PHD>()
                .Property(e => e.YR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAL_INFO>()
                .Property(e => e.PENSIONER)
                .IsUnicode(false);
        }
    }
}
