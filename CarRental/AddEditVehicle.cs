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
    public partial class AddEditVehicle : Form
    {
        public AddEditVehicle()
        {
            InitializeComponent();
            titleLable.Text = "Add New Vehicle";
        }

        public AddEditVehicle(TypesOfCar carToEdit) 
        {
            InitializeComponent();
            titleLable.Text = "Edit Vehicle";
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypesOfCar car)
        {
            makeValue.Text = car.Make;
            modelValue.Text = car.Model;
            vinValue.Text = car.VIN;
            yearValue.Text = car.Year.ToString();
            licensePlateValue.Text = car.LicensePlateNumber;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
