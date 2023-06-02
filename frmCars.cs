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
    public partial class frmCars : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = C:\data\hire.db"); // Connecting to database
        public frmCars()
        {
            InitializeComponent();
        }
        private void recordCount_TextChanged(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordControlNo} of {totalRecords}"; // Display the number of data in the records
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            recordCounter("next"); // go to the first position
            getData(); // get data of current position
        }

        private void formVehicleReg_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;
            CancelButton.Enabled = true;
            updatePanel.Visible = true;
        }

        private void formMake_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;
            CancelButton.Enabled = true;
            updatePanel.Visible = true;
        }

        private void formEngineSize_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;
            CancelButton.Enabled = true;
            updatePanel.Visible = true;
        }

        private void formDateRegistered_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;
            CancelButton.Enabled = true;
            updatePanel.Visible = true;
        }


        private void FirstButton_Click(object sender, EventArgs e)
        {
            recordCounter("first"); // go to the first position
            getData(); // get data of current position
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            recordCounter("previous"); // go to the first position
            getData(); // get data of current position
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            recordCounter("last"); // go to the first position
            getData(); // get data of current position
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult update = MessageBox.Show("Are you sure you'd like to Update this record?", "Update Record", MessageBoxButtons.YesNo);
            if(update == DialogResult.Yes)
            {
                updateRecords();
                MessageBox.Show("Record Updated");
            }
            else if(update == DialogResult.No)
            {
                MessageBox.Show("No record has been updated");
            }
            formMake.BackColor = Color.White;
            formEngineSize.BackColor = Color.White;
            formDateRegistered.BackColor = Color.White;
            formAvailable.BackColor = Color.White;
            formRentalPerDay.BackColor = Color.White;
        }

        private void updateRecords()
        {
            int offsetNumber = recordControlNo - 1;
            try
            {
                if(formAvailable.Checked == true)
                {
                    availablity = 1;
                }
                if(formAvailable.Checked == false)
                {
                    availablity = 0;
                }

                string updateArecord = $@"UPDATE tblCar SET VehicleRegNo = '" + formVehicleReg.Text + "', Make = '" + formMake.Text + "', Engine Size = '" + formEngineSize.Text + "', Date Registered = '" + formDateRegistered.Text + "', Rental Per Day = '" + formRentalPerDay.Value + "', Available = '" + availablity + "" + "'WHERE VehicleRegNo = (SELECT VehcileRegNo from tblCar limit 1 OFFSET '" + offsetNumber + "');";
                databaseConnection.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(databaseConnection); // Adds to the SQL in the database
                insertSQL.CommandText = updateArecord;
                insertSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                getData();
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot update data");
                return;
            }
        }

        private int availablity;
        private void AddButton_Click(object sender, EventArgs e)
        {
            frmAdd addForm = new frmAdd();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show($"Are you sure you'd like to delete this record? \nVehicle Registeration: {details.VehicleReg} \nMake: {details.Make} \nEngine Size: {details.Engine} \nDate Registeration: {details.DateReg} \nRentalPerDay: {details.RentalPerDay} \nAvailable: {details.Avaiable}", "Delete Record", MessageBoxButtons.YesNo);
            if(delete == DialogResult.Yes)
            {
                deleteData();
                MessageBox.Show("Record Deleted");
            }
            else if(delete == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
        }

        private void deleteData()
        {
            try
            {
                string deleteARecord = $@"DELETE FROM tblCar WHERE VehicleRegNo = '{formVehicleReg.Text}'";

                databaseConnection.Open();
                string sendData2 = deleteARecord;
                SQLiteCommand deleteSQL = new SQLiteCommand(databaseConnection);
                deleteSQL.CommandText = sendData2;
                deleteSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                recordCounter("last");
                getData();
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot delete data");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            frmSearch formSearch = new frmSearch();
            formSearch.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            getData();
            buttonUpdate.Enabled = false;
            CancelButton.Enabled = false;
            updatePanel.Visible = false;
            formMake.BackColor = Color.White;
            formEngineSize.BackColor = Color.White;
            formDateRegistered.BackColor = Color.White;
            formAvailable.BackColor = Color.White;
            formRentalPerDay.BackColor = Color.White;
        }

        private void formRentalPerDay_ValueChanged_1(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;
            CancelButton.Enabled = true;
            updatePanel.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        int recordControlNo = 1; // used in the number display at button of for 
        int totalRecords; // Where we store the total ammount of records
        public void recTotal()
        {
            string findTotal = @"SELECT COUNT(*) FROM tblCar"; // This will command will find all the counters

            databaseConnection.Open(); // Open the connection to the database
            var command = databaseConnection.CreateCommand(); // Creating a command 
            command.CommandText = findTotal; // turning the sql query into the command
            using (var reader = command.ExecuteReader()) // using the reader to excute the command
            {
                while (reader.Read())
                {
                    var total = reader.GetInt32(0);
                    totalRecords = total; // returns the query and stores the number as totalRecords
                }
            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}"; // Heres how we show our records
            databaseConnection.Close(); // Closing the database connection
        }

        public void recordCounter(string formButton)
        {
            if (formButton == "next")
            {// Determines behaviour of next button
                if (recordControlNo < totalRecords)
                {
                    recordControlNo += 1;
                }
            }
            if (formButton == "previous")
            {// Determines behaviour of previous button
                if (recordControlNo > 1)
                {
                    recordControlNo -= 1;
                }
            }
            if (formButton == "first")
            {// Determines behaviour of first button
                recordControlNo = 1;
            }
            if (formButton == "last")
            {// Determines behaviour of last button
                recordControlNo = totalRecords;
            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}"; // Updates the record button at the bottom.
        }

        Details details = new Details();
        public void getData()
        {
            int rowPosition = recordControlNo - 1;

            try
            { //Returns Data Based on Selected Record
                databaseConnection.Open(); //open connection
                string getDB = $@"SELECT * FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition})"; // used to get data from the database
                SQLiteCommand cmd = new SQLiteCommand(getDB, databaseConnection);
                DataTable dt = new DataTable(); // declaring dt as a new datatable
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); // adapter for collecting data from the database
                adapter.Fill(dt);

                frmDataGrid.DataSource = dt;
                databaseConnection.Close();

                formVehicleReg.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                formMake.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                formEngineSize.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                formDateRegistered.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                formRentalPerDay.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                int available = Convert.ToInt32(dt.Rows[0].ItemArray[6]);
                if (available == 1)
                {
                    formAvailable.Checked = true;
                }
                else
                {
                    formAvailable.Checked = false;
                }

                buttonUpdate.Enabled = false;
                CancelButton.Enabled = false;
                updatePanel.Visible = false;
                // Refenecing from the details program
                details.VehicleReg = formVehicleReg.Text;
                details.Make = formMake.Text;
                details.Engine = formEngineSize.Text;
                details.DateReg = formDateRegistered.Text;
                details.RentalPerDay = formRentalPerDay.Text;
                details.Avaiable = available;
            }

            catch
            {
                MessageBox.Show("Cannot find data");
            }
        }


        private void frmCars_Load(object sender, EventArgs e)
        {// This is what happens when to form loads
            try
            { // it will try and load all the records in the database
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Load database.  Check database connection."); // if 
            }

            buttonUpdate.Enabled = false; // Update button
            CancelButton.Enabled = false; // Cancel button
            updatePanel.Visible = false; // Panel button

            if (buttonUpdate.Enabled == true)
            {
                updatePanel.Visible = true;
            }
        }

        private void vehicleToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void rpdToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void carMakeToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmTooltip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void engineSizeTooltip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void dateRegTooltip_Popup_1(object sender, PopupEventArgs e)
        {


        }

        private void availTooltip_Popup(object sender, PopupEventArgs e)
        {


        }

        private void updatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
