namespace FormCars
{
    partial class frmSearch
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
            this.frmDataGrid = new System.Windows.Forms.DataGridView();
            this.RunButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.formOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmDataGrid
            // 
            this.frmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmDataGrid.Location = new System.Drawing.Point(61, 169);
            this.frmDataGrid.Name = "frmDataGrid";
            this.frmDataGrid.RowHeadersWidth = 51;
            this.frmDataGrid.RowTemplate.Height = 24;
            this.frmDataGrid.Size = new System.Drawing.Size(690, 150);
            this.frmDataGrid.TabIndex = 0;
            this.frmDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frmDataGrid_CellContentClick);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(602, 28);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(149, 51);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(602, 85);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(149, 57);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // formOperator
            // 
            this.formOperator.FormattingEnabled = true;
            this.formOperator.Location = new System.Drawing.Point(212, 62);
            this.formOperator.Name = "formOperator";
            this.formOperator.Size = new System.Drawing.Size(70, 24);
            this.formOperator.TabIndex = 6;
            this.formOperator.SelectedIndexChanged += new System.EventHandler(this.formOperator_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            // 
            // formValue
            // 
            this.formValue.Location = new System.Drawing.Point(326, 62);
            this.formValue.Multiline = true;
            this.formValue.Name = "formValue";
            this.formValue.Size = new System.Drawing.Size(168, 22);
            this.formValue.TabIndex = 1;
            this.formValue.TextChanged += new System.EventHandler(this.formValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operator";
            // 
            // formField
            // 
            this.formField.FormattingEnabled = true;
            this.formField.Location = new System.Drawing.Point(15, 62);
            this.formField.Name = "formField";
            this.formField.Size = new System.Drawing.Size(149, 24);
            this.formField.TabIndex = 5;
            this.formField.SelectedIndexChanged += new System.EventHandler(this.formField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.formValue);
            this.panel1.Controls.Add(this.formField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.formOperator);
            this.panel1.Location = new System.Drawing.Point(61, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 114);
            this.panel1.TabIndex = 9;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.frmDataGrid);
            this.Name = "frmSearch";
            this.Text = "Task A Search Robert Gannon";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView frmDataGrid;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox formOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}