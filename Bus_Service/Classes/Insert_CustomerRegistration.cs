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
    [Table("tblCustomerRegistration")]


    public class Insert_CustomerRegistration
    {
        [DataMember]
        [Key]
        public string Cust_Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        
        public string ContactNo { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public System.DateTime DOB { get; set; }
        [DataMember]
        public string Address { get; set; }
  
        [DataMember]
        public string Customer_Type { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}