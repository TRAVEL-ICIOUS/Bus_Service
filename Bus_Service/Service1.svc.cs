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
        ProjectDBCls P = new ProjectDBCls();
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

        public List<Insert_ScheduleInfo> GetScheduleId()
        {
            try
            {
                using (ProjectDBCls P = new ProjectDBCls())
                {
                    List<Insert_ScheduleInfo> L = P.Insert_ScheduleInfos.ToList();
                    return L;
                }
            }
            catch (DbUpdateException E)
            {
                SqlException S = (SqlException)E.GetBaseException();
                string St = S.Message;
                return null;
            }


        }

        //public List<Insert_ScheduleInfo> GetScheduleid()
        //{
        //    using (ProjectDBCls P = new ProjectDBCls())
        //    {
        //        return P.Insert_ScheduleInfos.ToList();
        //    }


        //}

        public   string InsertSeatsAvailInfo(Insert_availseats A)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.Insert_Availseats.Add(A);
                P.SaveChanges();
                //gfh
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }

        public string InsertScheduleInfo(Insert_ScheduleInfo S)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.Insert_ScheduleInfos.Add(S);
                P.SaveChanges();
                //gfh
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }

      public string InsertCS(CS Co)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.CSs.Add(Co);
                P.SaveChanges();
                //gfh
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }

      

        public List<string> GetCountry()
        {
            using (ProjectDBCls P = new ProjectDBCls())
            {
                //P.CustomerRegistrations.ToList();
                return P.CSs.Select(x=>x.CountryName).Distinct().ToList();
            }


        }


        public List<string> GetState(string Country)
        {
            
             ProjectDBCls P = new ProjectDBCls();

            
                P.Configuration.ProxyCreationEnabled = false;
            var S = from S1 in P.CSs
                    where S1.CountryName.Equals(Country)
                    select S1.StateName;
            List<string> L = S.ToList();
            return L;
            


        }

       

        public List<CustomerRegistration> Getmobileno()
        {
            using (ProjectDBCls P = new ProjectDBCls())
            {
                return P.CustomerRegistrations.ToList();
            }

        }

        public string InsertCustomer(CustomerRegistration Cr)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                Cr.CustomerId = getcustomerId();
               
                P.CustomerRegistrations.Add(Cr);
                P.SaveChanges();
                //gfh
                return "1 row inserted";
            }

            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }
       
        public  CustomerRegistration Userlogin(long Username,string Password)
        {
            try
            {
                var E = (from L in P.CustomerRegistrations
                         where L.MobileNo == Username && L.Password == Password
                         select L).FirstOrDefault();
                return E;
            }
            catch (DbUpdateException E)
            {
                SqlException ex = (SqlException)E.GetBaseException();
                //return ex.Message;
            }
            return null;
           
        }

        
        public string InsertTicketbooked(TicketBooking T)
        {
            try
            {
                ProjectDBCls P = new ProjectDBCls();
                P.TicketBookings.Add(T);
                P.SaveChanges();
                //gfh
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();//user friendly error include 
                return sql.Message;
            }
        }


        public int getcustomerId()
        {
            DateTime currentDate = DateTime.Now;
            string year = currentDate.Year.ToString();
            
            string month = currentDate.Month.ToString();
            if (Convert.ToInt32(month) < 10)
            {
                month = "0"+ month ;
            }
            Random rnd = new Random();
            string rndNo = rnd.Next(1111, 9999).ToString();

            return Convert.ToInt32(year + month + rndNo);
        }


        public List<string> GetFrom()
        {
            return P.Insert_RouteInfos.Select(x => x.RouteFrom).Distinct().ToList();
            
        }


        public List<string> GetTo(string From)
        {
            P.Configuration.ProxyCreationEnabled = false;
            var S = from S1 in P.Insert_RouteInfos
                    where S1.RouteFrom.Equals(From)
                    select S1.RouteTo;
            List<string> L = S.ToList();
            return L;

        }

        public List<int> getSecId()
        {
            ProjectDBCls P = new ProjectDBCls();
            var s = from S1 in P.Insert_ScheduleInfos
                    select S1.ScheduleID;
            return s.ToList();
            

        }

         public   List<ExtractBookingDetails> GetExtractBookings(String RouteFrom, String RouteTo, int NOT)
        {
            SqlParameter Param1 = new SqlParameter("@RouteFrom", RouteFrom);
            SqlParameter Param2 = new SqlParameter("@RouteTo", RouteTo);
            SqlParameter Param3 = new SqlParameter("@NOT", NOT);

            var res = P.Database.SqlQuery<ExtractBookingDetails>("dbo.sp_ExtractBD @RouteFrom,@RouteTo,@NOT", Param1, Param2, Param3).ToList();

            List<ExtractBookingDetails> L = new List<ExtractBookingDetails>();
            ExtractBookingDetails E = null;

            foreach(var r in res)
            {
                E = new ExtractBookingDetails();
                E.BusID = r.BusID;
                E.BusName = r.BusName;
                E.BusType = r.BusType;
                E.DepartureTime = r.DepartureTime;
                E.DoJ = r.DoJ;
                E.TotalCost = r.TotalCost;
                E.RouteID = r.RouteID;
                E.ScheduleID = r.ScheduleID;
                E.AvailableSeats = r.AvailableSeats;
                L.Add(E);
            }
            return L;


        }
        //public ExtractBookingDetails GetExtractBookingsById(int sid)
        //{
        //    GetExtractBookings
        //}
        public List<int> GetTicketId(int Cid)
        {
            ProjectDBCls P = new ProjectDBCls();

            var S = from S1 in P.TicketBookings
                    where S1.Customerid.Equals(Cid)
                    select S1.TicketID;
            List<int> L = S.ToList();
            return L;
        }

        public ExtractById getExtractBySid(int sid)
        {
            SqlParameter Param1 = new SqlParameter("@ScheduleID", sid);

            var res = P.Database.SqlQuery<ExtractById>("dbo.sp_getByScheduleId @ScheduleID", Param1).FirstOrDefault();

            
            ExtractById E = null;

            
                E = new ExtractById();
                E.BusName = res.BusName;
                E.BusType = res.BusType;
                E.DepartureTime = res.DepartureTime;
                E.BusId = res.BusId;
                E.RouteTo=res.RouteTo;
                E.RouteFrom = res.RouteFrom;
                E.ScheduleID = res.ScheduleID;

                
            return E;

        }
    }
}
