﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SunsetSunrise
{
    class SunMode
    {
        public string Status { get; set; }
        public Results Results { get; set; }
    }
    public class Results ////eraldi klass
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}
