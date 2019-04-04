using System;
using System.Collections.Generic;

namespace HZMStorage.Models
{
    public partial class MeasureRel
    {
        public int Id { get; set; }
        public string Sn { get; set; }
        public string MeasureSource { get; set; }
        public string MeasureTarget { get; set; }
        public double? Rate { get; set; }
    }
}
