using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CabSafe.Models
{
    public class TrackingReference
    {
        [Key]
        public int trackID { get; set; }
        public string SenderName { get; set; }
        public string PlateNum { get; set; }
        public string DriverName { get; set; }
        public string OtherMessage { get; set; }
        public string referenceCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}