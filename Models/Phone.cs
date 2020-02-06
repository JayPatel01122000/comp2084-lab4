using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BellMobiles.Models
{
    public class Phone
    {
        public Phone()
        {
            
            PhoneName = "";
            DateReleased = new DateTime();
        }
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        [Key]
        public int PhoneID { get; set; }
        public String PhoneName { get; set; }
        public virtual Manufacturer Manufacturer{ get; set; }
        public int MSRP { get; set; }
        public int ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }

    }


}