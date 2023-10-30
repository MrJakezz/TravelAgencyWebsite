using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
