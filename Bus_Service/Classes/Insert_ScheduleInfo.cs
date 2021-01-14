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
    [Table("tblScheduleInfo")]
    public class Insert_ScheduleInfo
    {

        [DataMember]
        [Key]

        public string ScheduleID { get; set; }

        [DataMember]
         
        public string Busid { get; set; }

        [ForeignKey("Busid")]
        public Insert_BusInfo Insert_BusInfo { get; set; }

        [DataMember]

        public string Routeid { get; set; }

        [ForeignKey("Routeid")]

        public Insert_RouteInfo Insert_RouteInfo { get; set; }

        [DataMember]

        public DateTime DepartureTime { get; set; }

        

    }
}