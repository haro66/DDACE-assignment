using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class Container
    {
        [Key]
        public int ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string ContainerDescription { get; set; }
        public int ContainerAmount { get; set; }
        public double ContainerWeight { get; set; }
    }
}