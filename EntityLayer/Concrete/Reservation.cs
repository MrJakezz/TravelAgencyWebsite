using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public string ReservationCapacity { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationDescription { get; set; }
        public string ReservationStatus { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }

    }
}
