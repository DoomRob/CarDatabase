namespace FormCars
{
    partial class frmAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.formRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.formAvailable = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.formVehicleReg = new System.Windows.Forms.TextBox();
            this.formMake = new System.Windows.Forms.TextBox();
            this.formEngineSize = new System.Windows.Forms.TextBox();
            this.formDateRegistered = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.formRentalPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vechile Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Engine Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Registered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rental Per Day";
            // 
            // formRentalPerDay
            // 
            this.formRentalPerDay.Location = new System.Drawing.Point(302, 202);
            this.formRentalPerDay.Name = "formRentalPerDay";
            this.formRentalPerDay.Size = new System.Drawing.Size(149, 22);
            this.formRentalPerDay.TabIndex = 5;
            this.formRentalPerDay.ValueChanged += new System.EventHandler(this.formRentalPerDay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Available";
            // 
            // formAvailable
            // 
            this.formAvailable.AutoSize = true;
            this.formAvailable.Location = new System.Drawing.Point(302, 239);
            this.formAvailable.Name = "formAvailable";
            this.formAvailable.Size = new System.Drawing.Size(18, 17);
            this.formAvailable.TabIndex = 7;
            this.formAvailable.UseVisualStyleBackColor = true;
            this.formAvailable.CheckedChanged += new System.EventHandler(this.formAvailable_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(48, 297);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 34);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(244, 297);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 35);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(428, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 35);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // formVehicleReg
            // 
            this.formVehicleReg.Location = new System.Drawing.Point(302, 57);
            this.formVehicleReg.Name = "formVehicleReg";
            this.formVehicleReg.Size = new System.Drawing.Size(149, 22);
            this.formVehicleReg.TabIndex = 11;
            this.formVehicleReg.TextChanged += new System.EventHandler(this.formVehicleReg_TextChanged);
            // 
            // formMake
            // 
            this.formMake.Location = new System.Drawing.Point(302, 92);
            this.formMake.Name = "formMake";
            this.formMake.Size = new System.Drawing.Size(222, 22);
            this.formMake.TabIndex = 12;
            this.formMake.TextChanged += new System.EventHandler(this.formMake_TextChanged);
            // 
            // formEngineSize
            // 
            this.formEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formEngineSize.Location = new System.Drawing.Point(302, 128);
            this.formEngineSize.Name = "formEngineSize";
            this.formEngineSize.Size = new System.Drawing.Size(149, 22);
            this.formEngineSize.TabIndex = 13;
            this.formEngineSize.TextChanged += new System.EventHandler(this.formEngineSize_TextChanged);
            // 
            // formDateRegistered
            // 
            this.formDateRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formDateRegistered.Location = new System.Drawing.Point(302, 165);
            this.formDateRegistered.Name = "formDateRegistered";
            this.formDateRegistered.Size = new System.Drawing.Size(149, 22);
            this.formDateRegistered.TabIndex = 14;
            this.formDateRegistered.TextChanged += new System.EventHandler(this.formDateRegistered_TextChanged);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formDateRegistered);
            this.Controls.Add(this.formEngineSize);
            this.Controls.Add(this.formMake);
            this.Controls.Add(this.formVehicleReg);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.formAvailable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.formRentalPerDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdd";
            this.Text = "Task A Add Robert Gannon";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formRentalPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown formRentalPerDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox formAvailable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox formVehicleReg;
        private System.Windows.Forms.TextBox formMake;
        private System.Windows.Forms.TextBox formEngineSize;
        private System.Windows.Forms.TextBox formDateRegistered;
    }
}