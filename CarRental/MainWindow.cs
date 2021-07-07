using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var addRentalRecord = new rentalForm();
            addRentalRecord.MdiParent = this;
            addRentalRecord.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
