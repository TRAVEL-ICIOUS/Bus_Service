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
    public class ExtractCancelDetails
    {
        [DataMember]

        public int ScheduleID { get; set; }

        [DataMember]

        public int NoOfTicketBooked { get; set; }


    }
}