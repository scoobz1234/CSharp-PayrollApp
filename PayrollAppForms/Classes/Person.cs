using System.Collections.Generic;
using System.Globalization;

namespace PayrollAppForms.Classes
{
    class Person
    {

        private TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        private string _firstName;
        private string _lastName;
        private PhoneNumber _phoneNumber;
        private List<Address> _addresses = new List<Address>();

        public Person() { }

        public Person(string firstName, string lastName, PhoneNumber phoneNum, Address address)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._phoneNumber = phoneNum;
            this._addresses.Add(address);
        }

        public string FirstName {
            get { return _firstName; }
            set { _firstName = ti.ToTitleCase(value); }
        }


        public string LastName {
            get { return _lastName; }
            set { _lastName = ti.ToTitleCase(value); }
        }


        public PhoneNumber PhoneNumber {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public List<Address> Addressses {
            get { return _addresses; }
            set { _addresses.Add(new Address()); }
        }

        public override string ToString()
        {
            return _lastName + ", " + _firstName + " " + _phoneNumber + " " + _addresses;
        }

    }
}
