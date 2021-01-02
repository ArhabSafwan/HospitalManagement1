namespace HospitalManagement1.PresentationLayer
{
    partial class EmployeeManagement
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
            this.EmployeelistGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddEmployeeStaflistcomboBox = new System.Windows.Forms.ComboBox();
            this.AddEmployeebutton = new System.Windows.Forms.Button();
            this.AddSalarytextBox = new System.Windows.Forms.TextBox();
            this.AddSpecialisttextBox = new System.Windows.Forms.TextBox();
            this.AddOccupationtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddEmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelistGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeelistGridView
            // 
            this.EmployeelistGridView.AllowUserToAddRows = false;
            this.EmployeelistGridView.AllowUserToDeleteRows = false;
            this.EmployeelistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeelistGridView.Location = new System.Drawing.Point(370, 92);
            this.EmployeelistGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeelistGridView.Name = "EmployeelistGridView";
            this.EmployeelistGridView.ReadOnly = true;
            this.EmployeelistGridView.RowHeadersWidth = 51;
            this.EmployeelistGridView.RowTemplate.Height = 24;
            this.EmployeelistGridView.Size = new System.Drawing.Size(292, 150);
            this.EmployeelistGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddEmployeeStaflistcomboBox);
            this.groupBox1.Controls.Add(this.AddEmployeebutton);
            this.groupBox1.Controls.Add(this.AddSalarytextBox);
            this.groupBox1.Controls.Add(this.AddSpecialisttextBox);
            this.groupBox1.Controls.Add(this.AddOccupationtextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddEmployeeNametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(326, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Employee";
            // 
            // AddEmployeeStaflistcomboBox
            // 
            this.AddEmployeeStaflistcomboBox.FormattingEnabled = true;
            this.AddEmployeeStaflistcomboBox.Location = new System.Drawing.Point(149, 213);
            this.AddEmployeeStaflistcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEmployeeStaflistcomboBox.Name = "AddEmployeeStaflistcomboBox";
            this.AddEmployeeStaflistcomboBox.Size = new System.Drawing.Size(116, 25);
            this.AddEmployeeStaflistcomboBox.TabIndex = 11;
            // 
            // AddEmployeebutton
            // 
            this.AddEmployeebutton.Location = new System.Drawing.Point(97, 260);
            this.AddEmployeebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEmployeebutton.Name = "AddEmployeebutton";
            this.AddEmployeebutton.Size = new System.Drawing.Size(82, 35);
            this.AddEmployeebutton.TabIndex = 10;
            this.AddEmployeebutton.Text = "Add";
            this.AddEmployeebutton.UseVisualStyleBackColor = true;
            this.AddEmployeebutton.Click += new System.EventHandler(this.AddEmployeebutton_Click);
            // 
            // AddSalarytextBox
            // 
            this.AddSalarytextBox.Location = new System.Drawing.Point(149, 178);
            this.AddSalarytextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddSalarytextBox.Name = "AddSalarytextBox";
            this.AddSalarytextBox.Size = new System.Drawing.Size(116, 23);
            this.AddSalarytextBox.TabIndex = 8;
            // 
            // AddSpecialisttextBox
            // 
            this.AddSpecialisttextBox.Location = new System.Drawing.Point(149, 135);
            this.AddSpecialisttextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddSpecialisttextBox.Name = "AddSpecialisttextBox";
            this.AddSpecialisttextBox.Size = new System.Drawing.Size(116, 23);
            this.AddSpecialisttextBox.TabIndex = 7;
            // 
            // AddOccupationtextBox
            // 
            this.AddOccupationtextBox.Location = new System.Drawing.Point(149, 93);
            this.AddOccupationtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOccupationtextBox.Name = "AddOccupationtextBox";
            this.AddOccupationtextBox.Size = new System.Drawing.Size(116, 23);
            this.AddOccupationtextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Staff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specialist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occupation";
            // 
            // AddEmployeeNametextBox
            // 
            this.AddEmployeeNametextBox.Location = new System.Drawing.Point(149, 37);
            this.AddEmployeeNametextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEmployeeNametextBox.Name = "AddEmployeeNametextBox";
            this.AddEmployeeNametextBox.Size = new System.Drawing.Size(116, 23);
            this.AddEmployeeNametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeelistGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelistGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeelistGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddEmployeeNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AddEmployeeStaflistcomboBox;
        private System.Windows.Forms.Button AddEmployeebutton;
        private System.Windows.Forms.TextBox AddSalarytextBox;
        private System.Windows.Forms.TextBox AddSpecialisttextBox;
        private System.Windows.Forms.TextBox AddOccupationtextBox;
    }
}