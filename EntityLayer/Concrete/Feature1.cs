using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature1
    {
        [Key]
        public int Feature1ID { get; set; }
        public string Feature1Title { get; set; }
        public string Feature1Description { get; set; }
        public string Feature1Image { get; set; }
        public bool Feature1Status { get; set; }
    }
}
