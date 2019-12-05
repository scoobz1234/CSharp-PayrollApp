using PayrollAppForms.Classes;
using System;
using System.Windows.Forms;

namespace PayrollAppForms
{
    public partial class FrmCreateEmployee : Form
    {
        public FrmCreateEmployee()
        {
            InitializeComponent();
        }

        //closes the window if the close button is clicked...
        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //if the create employee button is clicked do the following...
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string firstName = entFirstName.Text;
            string lastName = entLastName.Text;

            //Phone number data...
            //we parse into an int the entry boxes text value.
            int.TryParse(entAreaCode.Text, out int areaCode);
            int.TryParse(entPrefix.Text, out int prefix);
            int.TryParse(entLineNumber.Text, out int lineNumber);
            //with the data we got above, we create a phone number object...
            PhoneNumber phoneNumber = new PhoneNumber(areaCode, prefix, lineNumber);

            //we parse into strings and ints the values from the address entry boxes...
            int.TryParse(entNumber.Text, out int number);
            string street = entStreet.Text;
            string city = entCity.Text;
            string state = entState.Text;
            int.TryParse(entZipCode.Text, out int zip);
            //with the data we got above, we now create an Address object...
            Address fullAddress = new Address(number, street, city, state, zip);

            //employee information is populated here
            string title = entTitle.Text;
            bool payroll = cbPayroll.Checked;
            float wage = (float)nudWage.Value;
            float hoursWorked = (float)nudHours.Value;

            //now we create our employee and add it to the employee list. this calls the addemployee function...
            AddEmployee(title, lastName, firstName, wage, payroll, fullAddress, phoneNumber, hoursWorked);
        }

        //Function to create and store employee objects..
        void AddEmployee(string title, string last, string first, float wage, bool isOnPayroll, Address address, PhoneNumber pn, float hoursWorked = 0)
        {
            //create the employee object.
            Employee e = new Employee(title, last, first, wage, isOnPayroll, address, pn, hoursWorked);
            //add the employee to the list...
            Employees.EmployeeList.Add(e);
            //show a box that indicates success...
            MessageBox.Show($"Employee {e.LastName} has been added to the payroll","Success");
            //start the timer for window transition...
            tmrMoveOut.Start();
        }

        //the following functions just clear text in text boxes...
        private void EntFirstName_Click(object sender, EventArgs e)
        {
            entFirstName.Clear();
        }
        private void EntLastName_Click(object sender, EventArgs e)
        {
            entLastName.Clear();
        }
        private void EntAreaCode_Click(object sender, EventArgs e)
        {
            entAreaCode.Clear();
        }
        private void EntPrefix_Click(object sender, EventArgs e)
        {
            entPrefix.Clear();
        }
        private void EntLineNumber_Click(object sender, EventArgs e)
        {
            entLineNumber.Clear();
        }
        private void EntStreet_Click(object sender, EventArgs e)
        {
            entStreet.Clear();
        }
        private void EntNumber_Click(object sender, EventArgs e)
        {
            entNumber.Clear();
        }
        private void EntCity_Click(object sender, EventArgs e)
        {
            entCity.Clear();
        }
        private void EntState_Click(object sender, EventArgs e)
        {
            entState.Clear();
        }
        private void EntZipCode_Click(object sender, EventArgs e)
        {
            entZipCode.Clear();
        }
        private void EntTitle_Click(object sender, EventArgs e)
        {
            entTitle.Clear();
        }

        //this is the window slide out timer...
        private void TmrMoveOut_Tick(object sender, EventArgs e)
        {
            //move the window out 10 each tick
            this.Left += 10;
            //check if the window has reached its extended position
            if (this.Left > 1800)
            {
                //stop this timer
                tmrMoveOut.Stop();
                //set this window to the background
                this.TopMost = false;
                //start the move in timer...
                tmrMoveIn.Start();
            }
        }

        private void TmrMoveIn_Tick(object sender, EventArgs e)
        {
            //move in
            this.Left -= 10;
            //check if were there...
            if (this.Left <= 1375)
            {
                //stop the timer...
                tmrMoveIn.Stop();
                Hide();
            }
        }

        //if the cancel button is clicked or the X button at the top..
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //show a message box with yes and no buttons, and store the users selection as result.
            var result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation",MessageBoxButtons.YesNo);
            //if they press no, do nothing...
            if (result == DialogResult.No)
            {
                return;
            }
            //else start the transition move out timer...
            else
            {
                tmrMoveOut.Start();
            }
        }
    }
}
