﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "HealthInformation:" + HealthInformation
                + "Nationality:" + Nationality;
        }
        public override string GetPassengerType()
        {
            return "I am a traveller";
        }
    }
}
