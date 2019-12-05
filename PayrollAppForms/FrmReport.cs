using PayrollAppForms.Classes;
using System;
using System.Windows.Forms;

namespace PayrollAppForms
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void CmbEmployees_Click(object sender, EventArgs e)
        {
            //clear the combobox so we dont keep adding employees to it..
            cmbEmployees.Items.Clear();
            //for each employee in the employee list, add their first and 
            //last name to the combobox.
            foreach (Employee employee in Employees.EmployeeList)
            {
                cmbEmployees.Items.Add($"{employee.LastName}, {employee.FirstName}");
            }
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the value from the combo boxes seleted index.
            int index = cmbEmployees.SelectedIndex;
            //select employee by the index found above.
            Employee selectedEmployee = Employees.EmployeeList[index];
            
            //make the warning labels not visible once an employee is selected
            lblWarningTop.Visible = false;
            lblWarningBottom.Visible = false;

            //the following lines of code will make labels visible to the user.
            //they will also set the value of the labels to the appropriate values
            //of the selected employee..
            lblNumber.Visible = true;
            lblNumber.Text = selectedEmployee.Addressses[0].ApartmentNum.ToString();

            lblStreet.Visible = true;
            lblStreet.Text = selectedEmployee.Addressses[0].StreetAddress;

            lblCity.Visible = true;
            lblCity.Text = selectedEmployee.Addressses[0].City;
            
            lblZipCode.Visible = true;
            lblZipCode.Text = selectedEmployee.Addressses[0].Zip.ToString();

            lblState.Visible = true;
            lblState.Text = selectedEmployee.Addressses[0].State;

            lblPhoneNumber.Visible = true;
            lblPhoneNumber.Text = selectedEmployee.PhoneNumber.ToString();

            lblWage.Visible = true;
            lblCurrentWage.Visible = true;
            lblCurrentWage.Text = selectedEmployee.Wage.ToString();

            lblPay.Visible = true;
            lblCalculatedPay.Visible = true;
            lblCalculatedPay.Text = selectedEmployee.CalculatePay().ToString();

            lblHours.Visible = true;
            lblHoursWorked.Visible = true;
            lblHoursWorked.Text = selectedEmployee.HoursWorked.ToString();

        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            //get reference to the main menu form so we can show it...
            Form mm = Application.OpenForms[0];
            mm.Show();
            //hide the reports window...
            Hide();
        }
    }
}
