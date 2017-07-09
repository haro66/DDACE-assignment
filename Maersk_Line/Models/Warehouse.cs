using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseID { get; set; }

        public string WarehouseName { get; set; }
        public string Supervisor { get; set; }
        public int NumberOfContainersStored { get; set; }
    }
}