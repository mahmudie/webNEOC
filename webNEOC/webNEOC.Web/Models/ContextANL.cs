namespace webNEOC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using webNEOC.Models;

    public partial class ContextANL : DbContext
    {
        public ContextANL()
            : base("name=DTA")
        {
            Database.SetInitializer<ContextANL>(null);
        }
        public virtual DbSet<IndicatorsForDistrict> IndDistircts { get; set; }
        public virtual DbSet<IndicatorsForProvince> IndProvinces { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<LQAS> lqasLust { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
