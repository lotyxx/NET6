using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Model
{
    /// <summary>
    /// Reprezentuje jedno auto v programu.
    /// </summary>
    public class Car
    {
        // public Car (string SPZ)
        //{
        // this.SPZ = SPZ;
        //}
        //public string Spz { get; set; } // vlastnosti auta
        #region properties
        public string SPZ { get; internal set; } = "";// vlastnosti auta // "" prazdny string vs Null
        public string Color { get; set; } = "nezadana"; // priradi manualne hodnotu vlastnosti;

        public string Znacka { get; set; }

        public double NajeteKm { get; set; }
        public Person Owner { get; set; }
       # endregion

        public Car()
        {

        }
        public void AddKilometers (double km)
        {
            NajeteKm += km;
        }
        

       public void AddOneKm()
        {
            NajeteKm++;
        }

    }
}
