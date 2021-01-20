namespace Bus_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sp_ExtractBD : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.sp_ExtractBD",
                p => new
                {
                    RouteFrom = p.String(),
                    RouteTo= p.String(),
                    NOT=p.Int()
                },
                body:
                    @"select S.ScheduleID,B.BusID,R.RouteID,B.BusName,B.BusType,DepartureTime,RouteCost*@NOT TotalCost,A.AvailableSeats ,A.DoJ
                    from tblBusInfo B inner join tblScheduleInfo S on B.BusID=S.Busid 
                    inner join tblRouteInfo R on R.RouteID=S.Routeid
                    inner join tblseatsvail A on A.ScheduleID=S.ScheduleID
                    where 
                    R.RouteID in(select RouteID from tblRouteInfo where [RouteFrom]=@RouteFrom and [RouteTo]=@RouteTo)"
            );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.ExtractBookingDetails_Delete");
            DropStoredProcedure("dbo.ExtractBookingDetails_Update");
            DropStoredProcedure("dbo.ExtractBookingDetails_Insert");
            DropStoredProcedure("dbo.sp_ExtractBD");
           // DropTable("dbo.ExtractBookingDetails");
        }
    }
}
