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
    public partial class rentalForm : Form
    {
        private readonly CarRentalEntities1 carRentalEntities;
        public rentalForm()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities1();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var isValid = true;
            
                bool tryIF = true;
                try
                {
                    decimal cost = Convert.ToDecimal(costValue.Text);
                    string customerName = coustomerNameValue.Text;
                    var dateOut = pickUpDateTimePicker1.Value;
                    var dateIn = leaveDateTimePicker2.Value;

                    var carType = typeOfCarValue.Text;
                    var errorMessage = "";


                    isValid = true;
                    if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                    {
                        isValid = false;
                        errorMessage+= ("Error: Please enter missing data\n\r");

                    }

                    if (dateOut > dateIn)
                    {
                        isValid = false;
                        errorMessage += ("Error: Date Invalid\n\r");
                    }

                    if (isValid)
                    {
                        var rentalRecord = new CarRentalRecord();
                        rentalRecord.Name = customerName;
                        rentalRecord.DateOut = dateOut;
                        rentalRecord.DateIn = dateIn;
                        rentalRecord.Cost = cost;
                        rentalRecord.CarType = (int)typeOfCarValue.SelectedValue;

                        carRentalEntities.CarRentalRecords.Add(rentalRecord);
                        carRentalEntities.SaveChanges();


                        MessageBox.Show($"Thanks for renting {coustomerNameValue.Text}\n\r" +
                            $" Your car is a  {typeOfCarValue.Text}\n\r " +
                            $"will be ready for pickup {pickUpDateTimePicker1.Text}\n\r ");
                    }

                    tryIF = false;
                }
                catch (Exception ex )
                {
                    MessageBox.Show( ex.Message );
                    tryIF = true; 
                    throw;
                }
            
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var cars = carRentalEntities.TypesOfCars.ToList();

            var cars = carRentalEntities.TypesOfCars
                .Select(q => new 
                {  
                    ID = q.ID, 
                    Name = q.Make + " " + q.Model 
                })
                .ToList();

            typeOfCarValue.DisplayMember = "Name";
            typeOfCarValue.ValueMember = "ID";
            typeOfCarValue.DataSource = cars;
        }

       
    }
}
