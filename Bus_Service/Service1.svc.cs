using Bus_Service.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Bus_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       public string InsertBusInfo(Insert_BusInfo B)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.Insert_BusInfos.Add(B);
                P.SaveChanges();
                return "1 row inserted";
            }
            catch(DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }


        public string InsertRouteInfo(Insert_RouteInfo R)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.Insert_RouteInfos.Add(R);
                P.SaveChanges();
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }



        public List<Insert_BusInfo> GetBusid()
        {
            using (ProjectDBCls P=new ProjectDBCls())
            {
                return P.Insert_BusInfos.ToList();
            }


        }

        public List<Insert_RouteInfo> GetRouteid()
        {
            using (ProjectDBCls P = new ProjectDBCls())
            {
                return P.Insert_RouteInfos.ToList();
            }


        }

        public string InsertScheduleInfo(Insert_ScheduleInfo S)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.Insert_ScheduleInfos.Add(S);
                P.SaveChanges();
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }






    }
}
