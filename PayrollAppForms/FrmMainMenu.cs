using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollAppForms
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        //create and keep reference to the createemployee window...
        FrmCreateEmployee createEmployee= new FrmCreateEmployee();
        FrmReport reports = new FrmReport();
        
        //if the create employee button is clicked we start the window transition timer...
        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            createEmployee.Show();
            tmrMoveOut.Start();
        }

        //opens the report window on click...
        private void BtnReport_Click(object sender, EventArgs e)
        {
            //show the form...
            reports.Show();
            //hide main menu...
            Hide();
        }

        //timer for window transitions
        private void TmrMoveOut_Tick(object sender, EventArgs e)
        {
            //move the window out...
            createEmployee.Left += 10;
            //check if the window has reached its extended position...
            if (createEmployee.Left > 1800)
            {
                //stop this timer...
                tmrMoveOut.Stop();
                //set the new window to topmost so its in front...
                createEmployee.TopMost = true;
                //start the move in timer...
                tmrMoveIn.Start();
            }
        }

        //move in transition timer...
        private void TmrMoveIn_Tick(object sender, EventArgs e)
        {
            //move in...
            createEmployee.Left -= 10;
            //check if we have reached our position...
            if (createEmployee.Left <= 1375)
            {
                //stop the timer...
                tmrMoveIn.Stop();
            }
        }

        //if the user presses the x button we close the window...
        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
