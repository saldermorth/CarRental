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
    {//TOdo _db is null
        private readonly CarRentalEntities1 _db;
        private bool isEditMode;
        public AddEditVehicle()
        {
            InitializeComponent();
            titleLable.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntities1();
        }

        public AddEditVehicle(TypesOfCar carToEdit) 
        {
            InitializeComponent();
            titleLable.Text = "Edit Vehicle";
            PopulateFields(carToEdit);
            isEditMode = true;
        }

        private void PopulateFields(TypesOfCar car)
        {
            idLable.Text = car.ID.ToString();
            makeValue.Text = car.Make;
            modelValue.Text = car.Model;
            vinValue.Text = car.VIN;
            yearValue.Text = car.Year.ToString();
            licensePlateValue.Text = car.LicensePlateNumber;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                // TOdo -Car is null
                //Todo Edit code here
                var id = int.Parse(idLable.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.ID == id);
                car.Model = modelValue.Text;
                car.Make = makeValue.Text;
                car.VIN = vinValue.Text;
                car.Year = int.Parse(yearValue.Text);
                car.LicensePlateNumber = licensePlateValue.Text;

                _db.SaveChanges();
            }
            else
            {
                var newCar = new TypesOfCar
                {
                    LicensePlateNumber = licensePlateValue.Text,
                    Make = makeValue.Text,
                    Model = modelValue.Text,
                    VIN = vinValue.Text,
                    Year = int.Parse(yearValue.Text)
                };
            

                _db.TypesOfCars.Add(newCar);
                _db.SaveChanges();

                    
                
                //Todo Add code here
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
