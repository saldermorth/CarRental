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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities1 _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //Select  * From TypeOfCars
            //var cars = _db.TypesOfCars.ToList();

            //Select Id as CategoryAttribute ID , name as CarRental Name from types of cars
            var cars = _db.TypesOfCars
                .Select(q => new { ID = q.ID, NAME = q.name })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void addNewCarButton_Click(object sender, EventArgs e)
        {

        }

        private void editCarButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
