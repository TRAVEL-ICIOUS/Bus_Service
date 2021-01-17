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

        // string InsertScheduleInfo(Insert_ScheduleInfo S
        List<Insert_ScheduleInfo> GetScheduleid();

        [OperationContract]

        string InsertSeatsAvailInfo(Insert_availseats A);

        [OperationContract]

        string InsertCS(CS Co);

        [OperationContract]

        List<CS> GetCountry();

        [OperationContract]

        List<CS> GetState();

        [OperationContract]

        List<CustomerRegistration> Getmobileno();


        [OperationContract]

        string InsertCustomer(CustomerRegistration Cr);


        [OperationContract]

        string search(CustomerRegistration cr1);

        // [OperationContract]
        // List<CustomerRegistration> getcustomerId();












    }


    

    
}
