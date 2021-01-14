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
    [Table("tblAdminInfo")]

    public class AdminInfo
    {
        [DataMember]
        [Key]
        public string AdminId { get; set; }
        [DataMember]
        public string AdminUsername { get; set; }
        [DataMember]
        public string AdminPassword { get; set; }




    }
}