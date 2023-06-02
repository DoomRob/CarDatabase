using System;

namespace FormCars
{
    partial class frmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formAvailable = new System.Windows.Forms.CheckBox();
            this.formVehicleReg = new System.Windows.Forms.TextBox();
            this.formMake = new System.Windows.Forms.TextBox();
            this.formEngineSize = new System.Windows.Forms.TextBox();
            this.formDateRegistered = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.recordCount = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.vehicleRegToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.formRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.frmDataGrid = new System.Windows.Forms.DataGridView();
            this.rpdToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.carMakeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.frmTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.engineSizeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.dateRegTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.availTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.updatePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.formRentalPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle registration number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date registered";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rental per day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Available";
            // 
            // formAvailable
            // 
            this.formAvailable.AutoSize = true;
            this.formAvailable.Location = new System.Drawing.Point(364, 283);
            this.formAvailable.Name = "formAvailable";
            this.formAvailable.Size = new System.Drawing.Size(18, 17);
            this.formAvailable.TabIndex = 7;
            this.availTooltip.SetToolTip(this.formAvailable, "Check if the vehicle is available");
            this.formAvailable.UseVisualStyleBackColor = true;
            this.formAvailable.CheckedChanged += new System.EventHandler(this.formVehicleReg_TextChanged);
            // 
            // formVehicleReg
            // 
            this.formVehicleReg.Location = new System.Drawing.Point(364, 96);
            this.formVehicleReg.Name = "formVehicleReg";
            this.formVehicleReg.Size = new System.Drawing.Size(170, 22);
            this.formVehicleReg.TabIndex = 8;
            this.vehicleRegToolTip.SetToolTip(this.formVehicleReg, "Input your vehicle registration number here");
            this.formVehicleReg.TextChanged += new System.EventHandler(this.formVehicleReg_TextChanged);
            // 
            // formMake
            // 
            this.formMake.Location = new System.Drawing.Point(364, 133);
            this.formMake.Name = "formMake";
            this.formMake.Size = new System.Drawing.Size(243, 22);
            this.formMake.TabIndex = 9;
            this.carMakeToolTip.SetToolTip(this.formMake, "Enter the make of the car");
            this.formMake.TextChanged += new System.EventHandler(this.formMake_TextChanged);
            // 
            // formEngineSize
            // 
            this.formEngineSize.Location = new System.Drawing.Point(364, 172);
            this.formEngineSize.Name = "formEngineSize";
            this.formEngineSize.Size = new System.Drawing.Size(170, 22);
            this.formEngineSize.TabIndex = 10;
            this.engineSizeTooltip.SetToolTip(this.formEngineSize, "Input the size of the engine (e.g  1.4L)");
            this.formEngineSize.TextChanged += new System.EventHandler(this.formEngineSize_TextChanged);
            // 
            // formDateRegistered
            // 
            this.formDateRegistered.Location = new System.Drawing.Point(364, 206);
            this.formDateRegistered.Name = "formDateRegistered";
            this.formDateRegistered.Size = new System.Drawing.Size(137, 22);
            this.formDateRegistered.TabIndex = 11;
            this.dateRegTooltip.SetToolTip(this.formDateRegistered, "Input date (eg 2009-05-23)");
            this.formDateRegistered.TextChanged += new System.EventHandler(this.formDateRegistered_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(679, 43);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 50);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(679, 99);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 50);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(679, 155);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 50);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(679, 209);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 50);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(679, 265);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 50);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(679, 321);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 50);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(21, 379);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(100, 50);
            this.FirstButton.TabIndex = 19;
            this.FirstButton.Text = "&First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(127, 379);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(100, 50);
            this.PreviousButton.TabIndex = 20;
            this.PreviousButton.Text = "&Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // recordCount
            // 
            this.recordCount.Location = new System.Drawing.Point(233, 393);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(220, 22);
            this.recordCount.TabIndex = 21;
            this.recordCount.Text = "1 of 15";
            this.recordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recordCount.TextChanged += new System.EventHandler(this.recordCount_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(459, 379);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 50);
            this.NextButton.TabIndex = 22;
            this.NextButton.Text = "&Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(565, 379);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(100, 50);
            this.LastButton.TabIndex = 23;
            this.LastButton.Text = "&Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // vehicleRegToolTip
            // 
            this.vehicleRegToolTip.Tag = "Veh Reg";
            this.vehicleRegToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.vehicleToolTip_Popup);
            // 
            // formRentalPerDay
            // 
            this.formRentalPerDay.Location = new System.Drawing.Point(364, 243);
            this.formRentalPerDay.Name = "formRentalPerDay";
            this.formRentalPerDay.Size = new System.Drawing.Size(120, 22);
            this.formRentalPerDay.TabIndex = 26;
            this.rpdToolTip.SetToolTip(this.formRentalPerDay, "Input rental per day of vehicle");
            this.formRentalPerDay.ValueChanged += new System.EventHandler(this.formRentalPerDay_ValueChanged_1);
            // 
            // frmDataGrid
            // 
            this.frmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmDataGrid.Location = new System.Drawing.Point(886, 131);
            this.frmDataGrid.Name = "frmDataGrid";
            this.frmDataGrid.RowHeadersWidth = 51;
            this.frmDataGrid.RowTemplate.Height = 24;
            this.frmDataGrid.Size = new System.Drawing.Size(240, 150);
            this.frmDataGrid.TabIndex = 28;
            this.frmDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frmDataGrid_CellContentClick);
            // 
            // rpdToolTip
            // 
            this.rpdToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.rpdToolTip_Popup);
            // 
            // carMakeToolTip
            // 
            this.carMakeToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.carMakeToolTip_Popup);
            // 
            // frmTooltip
            // 
            this.frmTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.frmTooltip_Popup);
            // 
            // engineSizeTooltip
            // 
            this.engineSizeTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.engineSizeTooltip_Popup);
            // 
            // dateRegTooltip
            // 
            this.dateRegTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.dateRegTooltip_Popup_1);
            // 
            // availTooltip
            // 
            this.availTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.availTooltip_Popup);
            // 
            // updatePanel
            // 
            this.updatePanel.Location = new System.Drawing.Point(42, 76);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(623, 253);
            this.updatePanel.TabIndex = 29;
            this.updatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.updatePanel_Paint);
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.formDateRegistered);
            this.Controls.Add(this.formEngineSize);
            this.Controls.Add(this.formRentalPerDay);
            this.Controls.Add(this.formVehicleReg);
            this.Controls.Add(this.formMake);
            this.Controls.Add(this.frmDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.formAvailable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatePanel);
            this.Name = "frmCars";
            this.Text = "Task A Robert Gannon";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formRentalPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox formAvailable;
        private System.Windows.Forms.TextBox formVehicleReg;
        private System.Windows.Forms.TextBox formMake;
        private System.Windows.Forms.TextBox formEngineSize;
        private System.Windows.Forms.TextBox formDateRegistered;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.TextBox recordCount;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.ToolTip vehicleRegToolTip;
        private System.Windows.Forms.NumericUpDown formRentalPerDay;
        private System.Windows.Forms.DataGridView frmDataGrid;
        private System.Windows.Forms.ToolTip rpdToolTip;
        private System.Windows.Forms.ToolTip carMakeToolTip;
        private System.Windows.Forms.ToolTip frmTooltip;
        private System.Windows.Forms.ToolTip engineSizeTooltip;
        private System.Windows.Forms.ToolTip dateRegTooltip;
        private System.Windows.Forms.ToolTip availTooltip;
        private System.Windows.Forms.Panel updatePanel;
    }
}

