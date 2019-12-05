namespace PayrollAppForms.Classes
{
    class Employee : Person
    {
        private string _jobTitle;
        private float _wage;
        private float _hoursWorked;
        private bool _isOnPayroll;

        //default constructor...
        public Employee() { }

        //overloaded Constructor..
        public Employee(string title, string last, string first, float wage, bool isOnPayroll, Address address, PhoneNumber pn, float hoursWorked = 0)
        {
            _jobTitle = title;
            LastName = last;
            FirstName = first;
            _wage = wage;
            _hoursWorked = hoursWorked;
            _isOnPayroll = isOnPayroll;
            Addressses.Add(address);
            PhoneNumber = pn;
        }

        //Calculate the employee's pay by mult wage and hours worked..
        public float CalculatePay()
        {
            return (_wage * _hoursWorked);
        }

        public string JobTitle {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public float Wage {
            get { return _wage; }
            set { _wage = value; }
        }

        public float HoursWorked {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public bool IsOnPayroll {
            get { return _isOnPayroll; }
            set { _isOnPayroll = value; }
        }

        //override the to string method, so we can print how we want to...
        public override string ToString()
        {
            return _jobTitle + " " +
                this.FirstName + " " +
                this.LastName + " " +
                this.Addressses[0] + " " +
                this.PhoneNumber;
        }
    }
}
