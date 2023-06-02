using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FormCars
{
    // Module Code: 039
    // Surname: Gannon
    // C&G Number: HZH3499
    // Assignment: Asg A
    public partial class frmAdd : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"data source = C:\data\hire.db"); // Connecting to database
        public frmAdd()
        {
            InitializeComponent();
        }

        private int availability;
        private string returnedVeg;

        private void exitButton_Click(object sender, EventArgs e)
        {
            frmCars goToFormCars = new frmCars();
            this.Hide();
            goToFormCars.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (formVehicleReg.Text != "" && formMake.Text != "" && formDateRegistered.Text != "" && formEngineSize.Text != "" && formRentalPerDay.Value != 0)
            {
                try
                {
                    // The strings that will be used Database
                    string isRegInDB = $@"SELECT VehicleRegNo FROM tblCar WHERE VehicleRegNo = '" + formVehicleReg.Text + "'";
                    con.Open();

                    var command = con.CreateCommand();
                    command.CommandText = isRegInDB;

                    using (var reader = command.ExecuteReader())
                    {
                        // This code will make sure the records the user enters matches
                        while (reader.Read())
                        {
                            var reg = reader.GetString(0);
                            returnedVeg = reg;
                        }
                        if (formVehicleReg.Text == returnedVeg)
                        {
                            MessageBox.Show("Vehicle Registration Number may already exist in the database.");
                        }
                        if (formVehicleReg.Text != returnedVeg)
                        {
                            if (formAvailable.Checked == true)
                            {
                                availability = 1;
                            }
                            if (formAvailable.Checked == false)
                            {
                                availability = 0;
                            }

                            string addARecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES
                                                ('" + formVehicleReg.Text + "', '" + formMake.Text + "', '" + formEngineSize.Text + "', '" + formDateRegistered.Text + "', '" + formRentalPerDay.Value + "', '" + availability + "')";

                            SQLiteCommand insertSQL = new SQLiteCommand(addARecord, con);
                            insertSQL.CommandText = addARecord;
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("You have successfully added a new record to the database");
                            con.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot add data");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are completed");
            }
        }

        private void formVehicleReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void formMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void formDateRegistered_TextChanged(object sender, EventArgs e)
        {

        }

        private void formRentalPerDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            formVehicleReg.Text = "";
            formEngineSize.Text = "";
            formDateRegistered.Text = "";
            formMake.Text = "";
            formRentalPerDay.Value = 0;
            formAvailable.Checked = false;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void formEngineSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
