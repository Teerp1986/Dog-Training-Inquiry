using InquiryForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry_Form
{
    public class CustomerRepository
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public FurBaby FurBaby { get; set; }

        public InfoConfirmation InfoConfirmation { get; set; }
    }
}
