using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InquiryForm
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public FurBaby FurBaby { get; set; }

        public InfoConfirmation InfoConfirmation { get; set; }
    }
}
