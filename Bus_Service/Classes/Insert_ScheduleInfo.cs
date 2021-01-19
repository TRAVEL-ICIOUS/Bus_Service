using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bus_Service.Classes
{
    [DataContract()]

    [Table("tblScheduleInfo")]
    public class Insert_ScheduleInfo
    {

        [DataMember]
        [Key]

        public int ScheduleID { get; set; }

        [DataMember]
         
        public int Busid { get; set; }

        [ForeignKey("Busid")]
        public virtual Insert_BusInfo Insert_BusInfo { get; set; }

        [DataMember]

        public int Routeid { get; set; }

        [ForeignKey("Routeid")]

        public virtual Insert_RouteInfo Insert_RouteInfo { get; set; }

        [DataMember]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:hh\\:mm}")]
       
        public TimeSpan DepartureTime { get; set; }

        [DataMember]

        public int RouteCost { get; set; }

    //    public virtual IEnumerable<Insert_availseats> Insert_Availseats { get; set; }


    }
}