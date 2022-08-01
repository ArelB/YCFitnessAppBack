using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route
{
    public class Route
    {
        [Key]  
        public int RouteId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public double Distance { get; set; }
        public double GPSxStart { get; set; }
        public double GPSxEnd { get; set;}
        public double GPSyStart { get; set; }
        public double GPSyEnd { get; set; }
        public int FK_AutorID { get; set; }

    }
}
