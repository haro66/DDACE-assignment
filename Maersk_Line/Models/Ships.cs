using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class Ships
    {
        [Key]
        public int ShipID { get; set; }

        public string ShipName { get; set; }
        public string ShipDescription { get; set; }
        public int NumberOfContainersCarried { get; set; }
    }
}