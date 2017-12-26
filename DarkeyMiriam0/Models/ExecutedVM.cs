using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkeyMiriam0.Models
{
    public class ExecutedVM
    {

        public int IdRe { get; set; }
        public Nullable<System.DateTime> DateRequest_Re { get; set; }
        public Nullable<System.DateTime> CurrentDateRe { get; set; }
        public string CityRe { get; set; }
        public string AddressSourceRe { get; set; }
        public string AddressDestinationRe { get; set; }
        public Nullable<int> NumOfSeatsRe { get; set; }
        public string AdditionalPelephoneRe { get; set; }
        public Nullable<int> CodePatientRe { get; set; }
        public string dayRe { get; set; }
        public Nullable<System.TimeSpan> hourRe { get; set; }

        public int IdPa { get; set; }
        public string NamePa { get; set; }
        public int IdPatientPa { get; set; }
        public string TelephonePa { get; set; }
        public string PelephonePa { get; set; }
        public string AddressPa { get; set; }
        public string CityPa { get; set; }

        public int IdVol { get; set; }
        public string NameVol { get; set; }
        public int IdVolunteerVol { get; set; }
        public string TelephoneVol { get; set; }
        public string PelephoneVol { get; set; }
        public string AddressVol { get; set; }
        public string CityVol { get; set; }

        public int IdEx { get; set; }
        public Nullable<int> CodeRequestEx { get; set; }
        public Nullable<int> CodeVolunteerExEx { get; set; }
    }
}