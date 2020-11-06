using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSafety.Models
{
    public class Incidents
    {
        public int ID { get; set; }

        public string SiteCode { get; set; }

        public string DeviceID { get; set; }

        public string Grid { get; set; }

        [Display(Name = "Camera ID")]
        public int CameraID { get; set; }

        public string TimeStampAtSource { get; set; }

        public string TimestampAtSourceInLocalTimeZone { get; set; }

        public string Label { get; set; }

        public string FrameID { get; set; }

        public string Payload { get; set; }

        public string TimestampAtPlatform { get; set; }

        public string Url { get; set; }




    }
}
