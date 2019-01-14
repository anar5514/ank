using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class Anket
    {
        public Anket(string firstname, string lastname, string fathername, string country, string city, string phone, DateTime dateofbirth) { 
            Firstname = firstname;
            Lastname = lastname;
            Fathername = fathername;
            Country = country;
            City = city;
            Phone = phone;
            Dateofbirth = dateofbirth;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fathername { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Gender { get; set; }


    }
}
