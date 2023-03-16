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
        public frmAddEdit2(Garage obj)
        {
            InitializeComponent();
            db = new GarageEntities();
            if(obj == null)
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEdit2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
