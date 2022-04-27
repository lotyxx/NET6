using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Model
{
    public class Adress
    {
        public string Street { get; set; }
        public string City  { get; set; }
        public double PostalCode { get; set; }
        public string Country { get; set; }




        public Adress ( string street, string city, double postalcode, string country)
        {
            Street = street;
            City =    city;
            PostalCode = postalcode;
            Country = country;
               

        }


        }
}

