using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkeyMiriam0.Models
{
    public class RequestVM
    {
        public int IdRe { get; set; }
        public DateTime? DateRequest_Re { get; set; }
        public DateTime? CurrentDateRe { get; set; }
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
    }
}