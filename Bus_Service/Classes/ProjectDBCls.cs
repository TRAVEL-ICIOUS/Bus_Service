namespace Bus_Service.Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class ProjectDBCls : DbContext
    {
        public ProjectDBCls()
            : base("name=BUSDB")
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDBCls, Bus_Service.Migrations.Configuration>());

        }
        public DbSet<ExtractById> extractByIds { get; set; }
        public DbSet<Insert_BusInfo> Insert_BusInfos { get; set; }
        public DbSet<Insert_RouteInfo> Insert_RouteInfos { get; set; }
        public DbSet<Insert_ScheduleInfo> Insert_ScheduleInfos { get; set; }

        public DbSet<Insert_availseats> Insert_Availseats { get; set; }

        public DbSet<CS>CSs{ get; set; }

       


        public DbSet<TicketBooking> TicketBookings{ get; set; }

        public DbSet<CustomerRegistration> CustomerRegistrations { get; set; }

        public DbSet<ExtractBookingDetails> extractBookingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            


            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<ExtractBookingDetails>().MapToStoredProcedures();

        }
}
}
