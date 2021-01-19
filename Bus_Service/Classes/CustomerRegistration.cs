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
    [Table("tblcustregist")]
    public class CustomerRegistration
    {
        [Key]
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; } //yyyymm1234

        [DataMember]
        public string Name{ get; set; }

        [DataMember]

        public DateTime Dob { get; set; }

        [DataMember]

        public string Gender { get; set; }

        [DataMember]

        public string Customer_type { get; set; }

        [DataMember]

        public long MobileNo { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]

        public string Password { get; set; }

        [DataMember]
        public string Confirm_Password { get; set; }


        [DataMember]
        public string State { get; set; }
        //public int Stateid { get; set; }

      //  [ForeignKey("Stateid")]
      //  public virtual State State { get; set; }



        [DataMember]
        public string Country { get; set; }
        //public int Countryid { get; set; }

        //[ForeignKey("Countryid")]
        //public virtual Country Country { get; set; }

        [DataMember]
        public string City { get; set; }
        //public int Cityid { get; set; }

        //[ForeignKey("Cityid")]
        //public virtual City City { get; set; }

        [DataMember]

        public int Pincode { get; set; }




    }
}