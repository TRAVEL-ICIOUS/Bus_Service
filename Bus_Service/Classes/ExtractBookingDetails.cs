using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
namespace Bus_Service.Classes

{[DataContract]
    public class ExtractBookingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order =1)]
        [DataMember]
        public int RouteID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 2)]
        [DataMember]
     
        public int ScheduleID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 3)]
        [DataMember]
        public int BusID { get; set; }

       
        [DataMember]

        public string BusName { get; set; }

        [DataMember]

        public string BusType { get; set; }
       
        [DataMember]
        public TimeSpan DepartureTime { get; set; }
        [DataMember]

        public int TotalCost { get; set; }
        [DataMember]
        public DateTime? DoJ { get; set; }
        
        [DataMember]

        public int AvailableSeats { get; set; }

    }
}