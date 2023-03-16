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
    public partial class frmAddEdit2 : Form
    {
        GarageEntities db;
        public frmAddEdit2(car obj)
        {
            InitializeComponent();
            db = new GarageEntities();
            if(obj == null)
            {
                carBindingSource.DataSource = new car();
                db.cars.Add(carBindingSource.Current as car);
            }
            else
            {
                carBindingSource.DataSource = obj;
                db.cars.Attach(carBindingSource.Current as car);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEdit2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtColor.Text))
                {
                    MessageBox.Show("Proszę wprowadź kolor samochodu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtColor.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
