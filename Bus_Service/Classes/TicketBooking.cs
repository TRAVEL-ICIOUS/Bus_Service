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
    [Table("tblTicketBookingInfo")]
    public class TicketBooking
    {

        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketID { get; set; }


        [DataMember]

        public int Busid { get; set; }

        [ForeignKey("Busid")]


        public virtual Insert_BusInfo Insert_BusInfo { get; set; }


        [DataMember]

        public int Customerid { get; set; }

        [ForeignKey("Customerid")]

        public virtual CustomerRegistration CustomerRegistration { get; set; }


        [DataMember]

        public int Scheduleid { get; set; }

        [ForeignKey("Scheduleid")]

        public virtual Insert_ScheduleInfo Insert_ScheduleInfo { get; set; }

        [DataMember]

        public int NoOfTicketBooked { get; set; }

        [DataMember]

        public string RFrom { get; set; }

        [DataMember]

        public string RTo { get; set; }

        [DataMember]

        public string status { get; set; }

        [DataMember]

        [DisplayName("Start Date")]
        [DataType(DataType.Date, ErrorMessage = "Date not valid.")]
        [DisplayFormat(DataFormatString = "{0:dd\\-mm\\-yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]

        //[CustomDOJ]

        public DateTime DateOfJourney { get; set; }


    }
}