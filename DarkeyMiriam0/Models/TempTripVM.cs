using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkeyMiriam0.Models
{
    public class TempTripVM
    {
        public int IdTr { get; set; }
        public int CodeVolunteerTr { get; set; }
        public string dayTr { get; set; }
        public Nullable<System.TimeSpan> StartTimeTr { get; set; }
        public Nullable<System.TimeSpan> FinishTimeTr { get; set; }
        public string AddressSourceTr { get; set; }
        public string CityTr { get; set; }
        public Nullable<int> NumOfSeatsTr { get; set; }

        public int IdVol { get; set; }
        public string NameVol { get; set; }
        public int IdVolunteerVol { get; set; }
        public string TelephoneVol { get; set; }
        public string PelephoneVol { get; set; }
        public string AddressVol { get; set; }
        public string CityVol { get; set; }
    }
}