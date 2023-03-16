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
    }
}
