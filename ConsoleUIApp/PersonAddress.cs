using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUIApp
{
    public class PersonAddress
    {

        public string Street { private get; set; }
        //public string Address { get; set; }      

       

        public string City { private get; set; }
        public string State {  private get; set; }
        public int Zipcode { private get; set; }

        public string FullAddress
        {
            get

            {
                return $" My address is : {Street} {Zipcode },{City} {State}";

            }

        }

    }
}
