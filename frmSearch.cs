using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FormCars
{
    // Module Code: 039
    // Surname: Gannon
    // C&G Number: HZH3499
    // Assignment: Asg A
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void formValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void formField_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeOrAddOperators();
        }

        private void removeOrAddOperators()
        {
            if (formField.Text == "Available" || formField.Text == "Vehicle Registration Number" || formField.Text == "Make")
            {
                formOperator.Items.Remove("<");
                formOperator.Items.Remove(">");
                formOperator.Items.Remove("<=");
                formOperator.Items.Remove(">=");
            }
            if ((formField.Text == "Engine Size" || formField.Text == "Rental Per Day") && !formField.Items.Contains("<") && !formOperator.Items.Contains(">") && !formOperator.Items.Contains("<=") && !formOperator.Items.Contains(">="))
            {
                formOperator.Items.Add("<");
                formOperator.Items.Add(">");
                formOperator.Items.Add("<=");
                formOperator.Items.Add(">=");
            }
        }

        private void formOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void displayDB()
        {

        }

        private void frmDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            formField.Items.Add("Vehicle Registration Number");
            formField.Items.Add("Make");
            formField.Items.Add("Engine Size");
            formField.Items.Add("Rental Per Day");
            formField.Items.Add("Available");
            // = is a constant operator
            formOperator.Items.Add("=");
            searchData();
        }

        private void searchData()
        {
            string findData = @"SELECT * FROM tblCar";
            if (formField.Text != "" && formOperator.Text != "" && formValue.Text != "")
            {
                //Available
                if (formField.Text == "Available")
                {
                    if (formValue.Text == "Yes")
                    {
                        formOperator.Text = "=";
                        findData = $@"SELECT * FROM tblCar WHERE Available != 0";
                    }
                    else if (formValue.Text == "No")
                    {
                        formOperator.Text = "=";
                        findData = $@"SELECT * FROM tblCar WHERE Available = 0";
                    }
                    else if (formValue.Text != "Yes" || formValue.Text != "No")
                    {
                        MessageBox.Show("Please Enter 'Yes' or 'No'.  Ensure Capitals are present.");
                        formValue.Text = "";
                        return;
                    }
                }
                // Engine Size
                if (formField.Text == "Engine Size")
                {
                    findData = $@"SELECT * FROM tblCar WHERE EngineSize {formOperator.Text} '{formValue.Text.TrimEnd('L')}L'";
                }
                // Rental Per Day
                if (formField.Text == "Rental Per Day")
                {
                    findData = $@"SELECT * FROM tblCar WHERE RentalPerDay {formOperator.Text} '{formValue.Text}'";
                }
                // Make
                if (formField.Text == "Make")
                {
                    formOperator.Text = "=";
                    findData = $@"SELECT * FROM tblCar WHERE Make = '{formValue.Text}'";
                }
                // Vehicle Registration Number
                if (formField.Text == "Vehicle Registration Number")
                {
                    formOperator.Text = "=";
                    findData = $@"SELECT * FROM tblCar WHERE VehicleRegNo = '{formValue.Text}'";
                }

                SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = C:\data\hire.db");
                databaseConnection.Open();
                string query = findData;
                SQLiteCommand cmd = new SQLiteCommand(query, databaseConnection);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd);
                adapter2.Fill(dt);
                frmDataGrid.DataSource = dt;
                databaseConnection.Close();
            }
        }
    }
}
