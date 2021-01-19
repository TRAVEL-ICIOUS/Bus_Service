using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bus_Service.Classes
{
    [DataContract]
    [Table("tblRouteInfo")]
    public class Insert_RouteInfo
    {
        [DataMember]
        [Key]

        public int RouteID { get; set; }

        [DataMember]
        public string RouteFrom { get; set; }

        [DataMember]

        public string RouteTo { get; set; }

       
       // public virtual IEnumerable<Insert_ScheduleInfo> Insert_ScheduleInfo { get; set; }



    }
}