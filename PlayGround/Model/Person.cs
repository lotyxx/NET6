using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayGround.Model
{
    public class Person
    {

        public Person()
        {

        }
        public string order;
        public  Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;

            

        }

        public Adress Adress { get; set; } = new Adress();
        public DateTime DateOfBirth { get; set; }

        public string FirstName { get; set; } //zapis a cteni get a set
        public string LastName { get; set; }
        
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        

    }
}
