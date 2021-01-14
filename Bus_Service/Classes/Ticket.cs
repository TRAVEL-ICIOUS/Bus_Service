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
    [Table("tblTicketInfo")]
    public class Ticket
    {
        [DataMember]
        [Key]

        public string TicketID { get; set; }

        [DataMember]

        public string BusName { get; set; }

        [DataMember]

        public string BusType { get; set; }

        [DataMember]

        public int BusOrgCapacity { get; set; }

        public virtual IEnumerable<Insert_ScheduleInfo> Insert_ScheduleInfo { get; set; }




    }
}