using System;
namespace PropertyManager
{
    public class Address
    //Adress class contain: country, city, street and ZipCode.
    //Independent class that will be uses by other classes such as Property 
    //Fatima & Talal

    {
        private string country;
        private string city;
        private string street;
        private string zipCode;



        public string Country {
            get { return country;
            }
            set {  country = value;
            }
        }

        public string City
        {
            get { return city; }
            set { city = value;
            }
            
        }
        public string Street
        {
            get { return street;
            }
            set { street = value; }


        }
        public string ZipCode
        {
            get { return zipCode;
            }
            set { zipCode = value; }

        }
    }
}
