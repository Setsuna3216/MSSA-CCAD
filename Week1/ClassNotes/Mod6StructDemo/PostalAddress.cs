using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    // access specifiers help to control access of the entities created
    // internal: accessible only within assembly
    // private : to restrict access within the types, typically used for data members and functions 
    //which you do not want to expose
    //public : to allow the use of the functionality/property in the client code
    struct PostalAddress
    {
        //camelcase
        private int houseNumber;// member variable
        //pascal
        //proerties are just like mini functions meant to read/write data to the member variables
        public int HouseNumber
        {

            get
            {
                // formatting
                return houseNumber;
            }
            set
            {
                
                // validations
                if(value>0)
                houseNumber = value;
             //   HouseNumber = value;// call to itself , recursive call
            }
        }
        // member variable is provided by compiler
        public string StreetName { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        // constructor overload
        public PostalAddress(int housenumber,string streetname,string city,int zipcode)
        {
            this.houseNumber = housenumber;
            this.StreetName = streetname;
            this.City = city;
            this.ZipCode = zipcode;
            

        }
        public string PrintAddress()
        {
            return $"*****{HouseNumber}, {StreetName}, {City}, ZipCode:{ZipCode}*****";
        }

    }
}
