namespace DBFirstExample
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblShopping = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.rbFree = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.clbShop = new System.Windows.Forms.CheckedListBox();
            this.cbCOD = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbSelect = new System.Windows.Forms.ListBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.trainingDBDataSet = new DBFirstExample.TrainingDBDataSet();
            this.registerShppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShppingTableAdapter = new DBFirstExample.TrainingDBDataSetTableAdapters.RegisterShppingTableAdapter();
            this.btnSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(86, 115);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(78, 13);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Select Gender:";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(86, 177);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(100, 13);
            this.lblMembership.TabIndex = 2;
            this.lblMembership.Text = "Select Membership:";
            // 
            // lblShopping
            // 
            this.lblShopping.AutoSize = true;
            this.lblShopping.Location = new System.Drawing.Point(86, 225);
            this.lblShopping.Name = "lblShopping";
            this.lblShopping.Size = new System.Drawing.Size(143, 13);
            this.lblShopping.TabIndex = 3;
            this.lblShopping.Text = "Select Shopping Preference:";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(86, 359);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(126, 13);
            this.lblCash.TabIndex = 4;
            this.lblCash.Text = " Prefer Cash On Delivery:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(86, 413);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Enter Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 449);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 7;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(253, 107);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(241, 21);
            this.cbGender.TabIndex = 8;
            // 
            // rbFree
            // 
            this.rbFree.AutoSize = true;
            this.rbFree.Location = new System.Drawing.Point(253, 173);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(46, 17);
            this.rbFree.TabIndex = 9;
            this.rbFree.TabStop = true;
            this.rbFree.Text = "Free";
            this.rbFree.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(380, 173);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(46, 17);
            this.rbPaid.TabIndex = 10;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // clbShop
            // 
            this.clbShop.FormattingEnabled = true;
            this.clbShop.Items.AddRange(new object[] {
            "Groceries",
            "Apparels",
            "Cosmetics",
            "Footwear",
            "Electronics",
            "Accessories"});
            this.clbShop.Location = new System.Drawing.Point(254, 225);
            this.clbShop.Name = "clbShop";
            this.clbShop.Size = new System.Drawing.Size(240, 94);
            this.clbShop.TabIndex = 11;
            // 
            // cbCOD
            // 
            this.cbCOD.AutoSize = true;
            this.cbCOD.Location = new System.Drawing.Point(253, 359);
            this.cbCOD.Name = "cbCOD";
            this.cbCOD.Size = new System.Drawing.Size(55, 17);
            this.cbCOD.TabIndex = 12;
            this.cbCOD.Text = "COD?";
            this.cbCOD.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(253, 406);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(241, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(174, 449);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 23);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbSelect
            // 
            this.lbSelect.FormattingEnabled = true;
            this.lbSelect.Location = new System.Drawing.Point(595, 54);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(229, 368);
            this.lbSelect.TabIndex = 15;
            // 
            // cbID
            // 
            this.cbID.DataSource = this.registerShppingBindingSource;
            this.cbID.DisplayMember = "Name";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(254, 12);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 21);
            this.cbID.TabIndex = 16;
            this.cbID.ValueMember = "Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(535, 449);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShppingBindingSource
            // 
            this.registerShppingBindingSource.DataMember = "RegisterShpping";
            this.registerShppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // registerShppingTableAdapter
            // 
            this.registerShppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(713, 449);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(111, 23);
            this.btnSP.TabIndex = 19;
            this.btnSP.Text = "Call SP";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 484);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbCOD);
            this.Controls.Add(this.clbShop);
            this.Controls.Add(this.rbPaid);
            this.Controls.Add(this.rbFree);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblShopping);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblShopping;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.RadioButton rbFree;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.CheckedListBox clbShop;
        private System.Windows.Forms.CheckBox cbCOD;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lbSelect;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShppingTableAdapter registerShppingTableAdapter;
        private System.Windows.Forms.Button btnSP;
    }
}