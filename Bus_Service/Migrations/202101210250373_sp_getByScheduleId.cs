namespace Bus_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sp_getByScheduleId : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.sp_getByScheduleId",
                p => new
                {
                    ScheduleID = p.String(),
                },
                body:
                    @"select S.ScheduleID,S.DepartureTime,R.RouteFrom,R.RouteTo,B.BusName,B.Bustid,B.BusType from tblScheduleInfo S from tblScheduleInfo S
        inner join tblRouteInfo R
on R.RouteID=S.Routeid
inner join tblBusInfo B
on B.BusID=S.Busid
where ScheduleID=@ScheduleID"
            );
        }

        public override void Down()
        {
            DropStoredProcedure("sp_getByScheduleId");
            // DropTable("dbo.ExtractBookingDetails");
        }

    }


}

