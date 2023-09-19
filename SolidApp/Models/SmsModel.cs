using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SmsModel
    {
        public string? Message { get; set; }
        public BigInteger? PhoneNumber { get; set; }
        public DateTime? SendTime { get; set; }
    }
}
