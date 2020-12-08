using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSafety.Models
{
    public class IncidentViewModel
    {
        public int ID { get; set; }

        public string Grid { get; set; }

        [Display(Name = "Camera ID")]
        public int CameraID { get; set; }

        public string TimestampAtSourceInLocalTimeZone { get; set; }

        public string Url { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }
    }
}