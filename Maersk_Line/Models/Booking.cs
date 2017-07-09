using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maersk_Line.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public int WarehouseID { get; set; }
        public Warehouse warehouse { get; set; }

        [Required]
        public int ShipYardID { get; set; }
        public ShipYard shipyard { get; set; }

        [Required]
        public int ShipID { get; set; }
        public Ships ships { get; set; }

        [Required]
        public int ContainerID { get; set; }
        public Container container { get; set; }

        public double Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
    }
}