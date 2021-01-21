using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bus_Service.Classes
{
[DataContract]
    public class ExtractById
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 1)]
        [DataMember]
        public int ScheduleID { get; set; }

        [DataMember]
        public int BusId { get; set; }

        [DataMember]

        public string BusName { get; set; }

        [DataMember]

        public string BusType { get; set; }

        [DataMember]

        public string RouteFrom { get; set; }

        [DataMember]

        public string RouteTo { get; set; }

        [DataMember]
        public TimeSpan DepartureTime { get; set; }

        

    }
}