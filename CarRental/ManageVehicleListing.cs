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
            //var cars = _db.TypesOfCars
            //    .Select(q => new { ID = q.ID, Make = q.Make})
            //    .ToList();
            //gvVehicleList.DataSource = cars;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";

            var cars = _db.TypesOfCars
                 .Select(q => new 
                 { 
                     
                     Make = q.Make, 
                     Model = q.Model, 
                     VIN = q.VIN, 
                     Year = q.Year,
                     LicensePlateNumber = q.LicensePlateNumber,
                     q.ID,
                 })
                 .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "Licens Plate Number";
            gvVehicleList.Columns[5].Visible = false;
            

        }

        private void addNewCarButton_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void editCarButton_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["ID"].Value;
            //var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.ID == id);

            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["ID"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.ID == id);

            _db.TypesOfCars.Remove(car);
            _db.SaveChanges();
        }
    }
}
