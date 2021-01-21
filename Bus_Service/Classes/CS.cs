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
    [Table("tblcountry")]
    public class CS
    {
        [Key]
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [DataMember]

        public string CountryName { get; set; } //kl 10'o clock meeting 

        [DataMember]

        public string StateName { get; set; }

       // public virtual ICollection<CustomerRegistration> CustomerRegistration { get; set; }

        


    }
}