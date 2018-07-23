using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstExample
{
    public partial class Form1 : Form
    {
        TrainingDBEntities db = new TrainingDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.RegisterShpping' table. You can move, or remove it, as needed.
            this.registerShppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShpping);

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            //textbox
            string name = txtName.Text;
            //combobox
            string gender = cbGender.SelectedItem.ToString();
            //radiobutton
            string membership = "";
            if (rbFree.Checked)
                membership = rbFree.Text;
            if (rbPaid.Checked)
                membership = rbPaid.Text;
            //checkedlistbox
            string shopping = "";
            foreach (var d in clbShop.CheckedItems)
            {
                shopping += d + ",";
            }
            //checkbox
            string cod = "";
            if (cbCOD.Checked)
                cod = "Yes";
            else
                cod = "No";

            string pass = txtPassword.Text;
            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + shopping + "\n" + cod);

            //insert data to DB through Entity Framework
            RegisterShpping rs = new RegisterShpping();
            rs.Name = name;
            rs.Gender = gender;
            rs.Membership = membership;
            rs.ShoppingPreference = shopping;
            rs.COD = cod;
            rs.Password = pass;
            db.RegisterShppings.Add(rs);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Inserted");
            this.registerShppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShpping);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lbSelect.Items.Clear();
            foreach(var t in db.RegisterShppings)
            {
                lbSelect.Items.Add(t.Id);
                lbSelect.Items.Add(t.Name);
                lbSelect.Items.Add(t.Gender);
                lbSelect.Items.Add(t.Membership);
                lbSelect.Items.Add(t.ShoppingPreference);
                lbSelect.Items.Add(t.COD);
                lbSelect.Items.Add(t.Password);
                lbSelect.Items.Add("*******************");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id =(int)cbID.SelectedValue;
            var del = (from t in db.RegisterShppings where t.Id == id select t).SingleOrDefault();
            db.RegisterShppings.Remove(del);
            db.RegisterShppings.Remove(del);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data deleter");
            this.registerShppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShpping);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod = "";
            if (cbCOD.Checked)
                cod = "Yes";
            else
                cod = "No";

            string shopping = "";
            foreach (var d in clbShop.CheckedItems)
            {
                shopping += d + ",";
            }
            string membership = "";
            if (rbFree.Checked)
                membership = rbFree.Text;
            if (rbPaid.Checked)
                membership = rbPaid.Text;

            string pass = txtPassword.Text;
            int id = (int)cbID.SelectedValue;
            var old = db.RegisterShppings.Where(x => x.Id == id).SingleOrDefault();
            old.Membership = membership;
            old.ShoppingPreference = shopping;
            old.COD = cod;
            old.Password = pass;
            old.Id = id;
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Updated");


        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            int id = (int)cbID.SelectedValue;
            lbSelect.Items.Clear();
            var res = db.sp_SelectRegisterShpping(id);
            foreach (var r in res)
            {
                lbSelect.Items.Add(r.Id);
                lbSelect.Items.Add(r.Name);
                lbSelect.Items.Add(r.Gender);
                lbSelect.Items.Add(r.Membership);
                lbSelect.Items.Add(r.ShoppingPreference);
                lbSelect.Items.Add(r.COD);
                lbSelect.Items.Add(r.Password);
            }
        }
    }
}
