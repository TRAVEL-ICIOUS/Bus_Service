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
        [Table("tblseatsvail")]
        public class Insert_availseats
        {
            [Key]
            [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AID { get; set; }
            [DataMember]


            public int ScheduleID { get; set; }
            [ForeignKey("ScheduleID")]
           public Insert_ScheduleInfo Insert_ScheduleInfo { get; set; }
            [DataMember]
            [DisplayName("Start Date")]
            [DataType(DataType.Date, ErrorMessage = "Date not valid.")]
            [DisplayFormat(DataFormatString = "{0:dd\\-mm\\-yyyy}", ApplyFormatInEditMode = true)]
            //[DataType(DataType.Date)]
            public DateTime? DoJ { get; set; }



            [DataMember]



            public int GeneralSeats { get; set; }



            [DataMember]



            public int AvailableSeats { get; set; }


        }
    }