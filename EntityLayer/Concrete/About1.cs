using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About1
    {
        [Key]
        public int About1ID { get; set; }
        public string About1Title1 { get; set; }
        public string About1Description { get; set; }
        public string About1Image { get; set; }
        public string About1Title2 { get; set; }
        public string About1Description2 { get; set; }
        public bool About1Status { get; set; }
    }
}
