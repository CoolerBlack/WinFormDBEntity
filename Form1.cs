using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDBEntity
{
    public partial class Form1 : Form
    {
        GarageEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new GarageEntities();
            carBindingSource.DataSource = db.cars.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(frmAddEdit2 frm = new frmAddEdit2(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    carBindingSource.DataSource = db.cars.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (carBindingSource.Current == null)
                return;
            using (frmAddEdit2 frm = new frmAddEdit2(carBindingSource.Current as car))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    carBindingSource.DataSource = db.cars.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(carBindingSource.Current != null)
            {
                if(MessageBox.Show("Czy chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.cars.Remove(carBindingSource.Current as car);
                    carBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
