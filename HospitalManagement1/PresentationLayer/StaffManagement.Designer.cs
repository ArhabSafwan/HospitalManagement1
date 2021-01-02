
namespace HospitalManagement1.PresentationLayer
{
    partial class StaffManagement
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
            this.loadStaffDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.addStaffNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateStaffButton = new System.Windows.Forms.Button();
            this.updateStaffNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteStaffButton = new System.Windows.Forms.Button();
            this.deleteStaffIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StaffwiseEmployeelistdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchStaffcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadStaffDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffwiseEmployeelistdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadStaffDataGridView
            // 
            this.loadStaffDataGridView.AllowUserToAddRows = false;
            this.loadStaffDataGridView.AllowUserToDeleteRows = false;
            this.loadStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadStaffDataGridView.Location = new System.Drawing.Point(335, 55);
            this.loadStaffDataGridView.Name = "loadStaffDataGridView";
            this.loadStaffDataGridView.ReadOnly = true;
            this.loadStaffDataGridView.Size = new System.Drawing.Size(240, 150);
            this.loadStaffDataGridView.TabIndex = 0;
            this.loadStaffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadStaffDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of Staffs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addStaffButton);
            this.groupBox1.Controls.Add(this.addStaffNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Add New Staff";
            // 
            // addStaffButton
            // 
            this.addStaffButton.Location = new System.Drawing.Point(146, 75);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(75, 32);
            this.addStaffButton.TabIndex = 2;
            this.addStaffButton.Text = "Add";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // addStaffNameTextBox
            // 
            this.addStaffNameTextBox.Location = new System.Drawing.Point(63, 27);
            this.addStaffNameTextBox.Name = "addStaffNameTextBox";
            this.addStaffNameTextBox.Size = new System.Drawing.Size(179, 26);
            this.addStaffNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateStaffButton);
            this.groupBox2.Controls.Add(this.updateStaffNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Staff";
            // 
            // updateStaffButton
            // 
            this.updateStaffButton.Location = new System.Drawing.Point(146, 75);
            this.updateStaffButton.Name = "updateStaffButton";
            this.updateStaffButton.Size = new System.Drawing.Size(75, 32);
            this.updateStaffButton.TabIndex = 2;
            this.updateStaffButton.Text = "Save";
            this.updateStaffButton.UseVisualStyleBackColor = true;
            this.updateStaffButton.Click += new System.EventHandler(this.updateStaffButton_Click);
            // 
            // updateStaffNameTextBox
            // 
            this.updateStaffNameTextBox.Location = new System.Drawing.Point(63, 27);
            this.updateStaffNameTextBox.Name = "updateStaffNameTextBox";
            this.updateStaffNameTextBox.Size = new System.Drawing.Size(179, 26);
            this.updateStaffNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Staff";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteStaffButton);
            this.groupBox3.Controls.Add(this.deleteStaffIdTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove Staff";
            // 
            // deleteStaffButton
            // 
            this.deleteStaffButton.Location = new System.Drawing.Point(146, 72);
            this.deleteStaffButton.Name = "deleteStaffButton";
            this.deleteStaffButton.Size = new System.Drawing.Size(83, 32);
            this.deleteStaffButton.TabIndex = 2;
            this.deleteStaffButton.Text = "Remove";
            this.deleteStaffButton.UseVisualStyleBackColor = true;
            this.deleteStaffButton.Click += new System.EventHandler(this.deleteStaffButton_Click);
            // 
            // deleteStaffIdTextBox
            // 
            this.deleteStaffIdTextBox.Location = new System.Drawing.Point(63, 28);
            this.deleteStaffIdTextBox.Name = "deleteStaffIdTextBox";
            this.deleteStaffIdTextBox.Size = new System.Drawing.Size(179, 26);
            this.deleteStaffIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Staff";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StaffwiseEmployeelistdataGridView);
            this.groupBox4.Controls.Add(this.SearchStaffcomboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(325, 224);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(398, 266);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Staff\'s category wise Employee List";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // StaffwiseEmployeelistdataGridView
            // 
            this.StaffwiseEmployeelistdataGridView.AllowUserToAddRows = false;
            this.StaffwiseEmployeelistdataGridView.AllowUserToDeleteRows = false;
            this.StaffwiseEmployeelistdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffwiseEmployeelistdataGridView.Location = new System.Drawing.Point(22, 98);
            this.StaffwiseEmployeelistdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.StaffwiseEmployeelistdataGridView.Name = "StaffwiseEmployeelistdataGridView";
            this.StaffwiseEmployeelistdataGridView.ReadOnly = true;
            this.StaffwiseEmployeelistdataGridView.RowHeadersWidth = 51;
            this.StaffwiseEmployeelistdataGridView.RowTemplate.Height = 24;
            this.StaffwiseEmployeelistdataGridView.Size = new System.Drawing.Size(351, 148);
            this.StaffwiseEmployeelistdataGridView.TabIndex = 3;
            // 
            // SearchStaffcomboBox
            // 
            this.SearchStaffcomboBox.FormattingEnabled = true;
            this.SearchStaffcomboBox.Location = new System.Drawing.Point(111, 45);
            this.SearchStaffcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchStaffcomboBox.Name = "SearchStaffcomboBox";
            this.SearchStaffcomboBox.Size = new System.Drawing.Size(138, 28);
            this.SearchStaffcomboBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Staff";
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 516);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadStaffDataGridView);
            this.Name = "StaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffManagement_FormClosing);
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadStaffDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffwiseEmployeelistdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadStaffDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.TextBox addStaffNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateStaffButton;
        private System.Windows.Forms.TextBox updateStaffNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteStaffButton;
        private System.Windows.Forms.TextBox deleteStaffIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView StaffwiseEmployeelistdataGridView;
        private System.Windows.Forms.ComboBox SearchStaffcomboBox;
        private System.Windows.Forms.Label label5;
    }
}