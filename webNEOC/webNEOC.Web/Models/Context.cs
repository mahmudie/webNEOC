namespace webNEOC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using webNEOC.Models;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Default")
        {
            Database.SetInitializer<Context>(null);
        }

        //public virtual DbSet<Roundx> roundx { get; set; }
        //public virtual DbSet<mVIT> VitaminAData { get; set; }
        public virtual DbSet<Models.TreeGrid.Regions> Regionlist { get; set; }
        public virtual DbSet<Formsubmission> formSubmission { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
