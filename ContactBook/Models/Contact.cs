using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }



    }
}
