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
 [Table("tblBusInfo")]
    public class Insert_BusInfo
    {
        [DataMember]
        [Key]

        public string BusID { get; set; }

        [DataMember]

        public string BusName { get; set; }

        [DataMember]

        public string BusType { get; set; }

        [DataMember]

        public int BusOrgCapacity { get; set; }

        public virtual IEnumerable<Insert_ScheduleInfo> Insert_ScheduleInfo { get; set; }



    }
}