using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Statistics
    {
        public double Average { get; set; }
        public double High { get; set; } = double.MinValue;
        public double Low { get; set; } = double.MaxValue;
        public char Letter { get; set; }
    }
}
