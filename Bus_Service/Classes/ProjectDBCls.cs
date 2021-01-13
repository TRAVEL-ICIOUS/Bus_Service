namespace Bus_Service.Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjectDBCls : DbContext
    {
        public ProjectDBCls()
            : base("name=ProjectDBCls")
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDBCls, Bus_Service.Migrations.Configuration>());

        }

        public DbSet<Insert_BusInfo> Insert_BusInfos { get; set; }
        public DbSet<Insert_RouteInfo> Insert_RouteInfos { get; set; }
        public DbSet<Insert_ScheduleInfo> Insert_ScheduleInfos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
