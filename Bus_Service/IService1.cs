using Bus_Service.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Bus_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        
        ExtractById getExtractBySid(int sid);
        [OperationContract]


        string InsertBusInfo(Insert_BusInfo B);

        [OperationContract]

       string InsertRouteInfo(Insert_RouteInfo R);

        [OperationContract]

        // string InsertScheduleInfo(Insert_ScheduleInfo S
        List<Insert_BusInfo> GetBusid();

        [OperationContract]

        // string InsertScheduleInfo(Insert_ScheduleInfo S
        List<Insert_RouteInfo> GetRouteid();

        [OperationContract]
        string InsertScheduleInfo(Insert_ScheduleInfo S);

        [OperationContract]

        List<Insert_ScheduleInfo> GetScheduleId();

        // [OperationContract]

        [OperationContract]
        List<int> getSecId();

        //// string InsertScheduleInfo(Insert_ScheduleInfo S
        //List<Insert_ScheduleInfo> GetScheduleid();

        [OperationContract]

        string InsertSeatsAvailInfo(Insert_availseats A);

        [OperationContract]

        string InsertCS(CS Co);

        [OperationContract]

        List<string> GetCountry();

        [OperationContract]

        List<string> GetState(string Country);

        [OperationContract]

        List<CustomerRegistration> Getmobileno();


        [OperationContract]

        string InsertCustomer(CustomerRegistration Cr);

        [OperationContract]
        CustomerRegistration Userlogin(long Username, string Password);

        [OperationContract]
        string InsertTicketbooked(TicketBooking T);
        //string InsertTicket(int sid, int seats, int custid,Ticket tt);

        [OperationContract]
        List<string> GetFrom();

        [OperationContract]
        List<int> GetTicketId(int Cid);

        [OperationContract]
        List<string> GetTo(string From);

        //string search(CustomerRegistration cr1);

        [OperationContract]
        List<ExtractBookingDetails> GetExtractBookings(String RouteFrom, String RouteTo, int NOT);
       












    }





}
