using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollAppForms.Classes
{
    class Address
    {

        public string StreetAddress { get; set; }
        public int ApartmentNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public Address() { }

        public Address(int aptNum, string street, string city, string state, int zip)
        {
            this.StreetAddress = street;
            this.ApartmentNum = aptNum;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        public override string ToString()
        {
            return ApartmentNum + " " + StreetAddress + " " + City +
                " " + State + " " + Zip;
        }

    }
}
