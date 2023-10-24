using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactUs
    {
        public int ContactUsID { get; set; }
        public string ContactUsName { get; set; }
        public string ContactUsMail { get; set; }
        public string ContactUsSubject { get; set; }
        public string ContactUsBody { get; set; }
        public DateTime ContactUsMessageDate { get; set; }
        public bool ContactUsStatus { get; set; }
    }
}
