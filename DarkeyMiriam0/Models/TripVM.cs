using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkeyMiriam0.Models
{
    public class TripVM
    {
        public TripVM() { }
        public int IdTr { get; set; }
        public int CodeVolunteer { get; set; }
        public string Day { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> FinishTime { get; set; }
        public string AddressSource { get; set; }
        public string CityTr { get; set; }
        public Nullable<int> NumOfSeats { get; set; }
        public string Note { get; set; }

        public int IdVol { get; set; }
        public string Name { get; set; }
        public int IdVolunteer { get; set; }
        public string Telephone { get; set; }
        public string Pelephone { get; set; }
        public string Address { get; set; }
        public string CityVol { get; set; }

    }
}