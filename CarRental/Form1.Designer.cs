
namespace CarRental
{
    partial class rentalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CarRentalLable = new System.Windows.Forms.Label();
            this.coustomerNameValue = new System.Windows.Forms.TextBox();
            this.customerNameLable = new System.Windows.Forms.Label();
            this.pickUpDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.leaveDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.leveDateLable = new System.Windows.Forms.Label();
            this.pickUpDateLable = new System.Windows.Forms.Label();
            this.typeOfCarValue = new System.Windows.Forms.ComboBox();
            this.typeOfCarLable = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.costValue = new System.Windows.Forms.TextBox();
            this.costLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarRentalLable
            // 
            this.CarRentalLable.AutoSize = true;
            this.CarRentalLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRentalLable.Location = new System.Drawing.Point(217, 35);
            this.CarRentalLable.Name = "CarRentalLable";
            this.CarRentalLable.Size = new System.Drawing.Size(347, 42);
            this.CarRentalLable.TabIndex = 0;
            this.CarRentalLable.Text = "Car Rental System";
            // 
            // coustomerNameValue
            // 
            this.coustomerNameValue.Location = new System.Drawing.Point(12, 150);
            this.coustomerNameValue.Name = "coustomerNameValue";
            this.coustomerNameValue.Size = new System.Drawing.Size(200, 20);
            this.coustomerNameValue.TabIndex = 1;
            // 
            // customerNameLable
            // 
            this.customerNameLable.AutoSize = true;
            this.customerNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLable.Location = new System.Drawing.Point(12, 124);
            this.customerNameLable.Name = "customerNameLable";
            this.customerNameLable.Size = new System.Drawing.Size(118, 16);
            this.customerNameLable.TabIndex = 2;
            this.customerNameLable.Text = "Customer Name";
            // 
            // pickUpDateTimePicker1
            // 
            this.pickUpDateTimePicker1.Location = new System.Drawing.Point(12, 209);
            this.pickUpDateTimePicker1.Name = "pickUpDateTimePicker1";
            this.pickUpDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.pickUpDateTimePicker1.TabIndex = 3;
            // 
            // leaveDateTimePicker2
            // 
            this.leaveDateTimePicker2.Location = new System.Drawing.Point(403, 209);
            this.leaveDateTimePicker2.Name = "leaveDateTimePicker2";
            this.leaveDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.leaveDateTimePicker2.TabIndex = 4;
            // 
            // leveDateLable
            // 
            this.leveDateLable.AutoSize = true;
            this.leveDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leveDateLable.Location = new System.Drawing.Point(403, 183);
            this.leveDateLable.Name = "leveDateLable";
            this.leveDateLable.Size = new System.Drawing.Size(88, 16);
            this.leveDateLable.TabIndex = 5;
            this.leveDateLable.Text = "Leave Date";
            // 
            // pickUpDateLable
            // 
            this.pickUpDateLable.AutoSize = true;
            this.pickUpDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpDateLable.Location = new System.Drawing.Point(12, 183);
            this.pickUpDateLable.Name = "pickUpDateLable";
            this.pickUpDateLable.Size = new System.Drawing.Size(94, 16);
            this.pickUpDateLable.TabIndex = 5;
            this.pickUpDateLable.Text = "Pick up date";
            // 
            // typeOfCarValue
            // 
            this.typeOfCarValue.FormattingEnabled = true;
            this.typeOfCarValue.Location = new System.Drawing.Point(12, 311);
            this.typeOfCarValue.Name = "typeOfCarValue";
            this.typeOfCarValue.Size = new System.Drawing.Size(200, 21);
            this.typeOfCarValue.TabIndex = 6;
            // 
            // typeOfCarLable
            // 
            this.typeOfCarLable.AutoSize = true;
            this.typeOfCarLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfCarLable.Location = new System.Drawing.Point(12, 283);
            this.typeOfCarLable.Name = "typeOfCarLable";
            this.typeOfCarLable.Size = new System.Drawing.Size(89, 16);
            this.typeOfCarLable.TabIndex = 5;
            this.typeOfCarLable.Text = "Type of Car";
            // 
            // submitButton
            // 
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(403, 283);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(200, 80);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // costValue
            // 
            this.costValue.Location = new System.Drawing.Point(406, 150);
            this.costValue.Name = "costValue";
            this.costValue.Size = new System.Drawing.Size(197, 20);
            this.costValue.TabIndex = 8;
            // 
            // costLable
            // 
            this.costLable.AutoSize = true;
            this.costLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLable.Location = new System.Drawing.Point(403, 124);
            this.costLable.Name = "costLable";
            this.costLable.Size = new System.Drawing.Size(39, 16);
            this.costLable.TabIndex = 9;
            this.costLable.Text = "Cost";
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Launch Main Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costLable);
            this.Controls.Add(this.costValue);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.typeOfCarValue);
            this.Controls.Add(this.typeOfCarLable);
            this.Controls.Add(this.pickUpDateLable);
            this.Controls.Add(this.leveDateLable);
            this.Controls.Add(this.leaveDateTimePicker2);
            this.Controls.Add(this.pickUpDateTimePicker1);
            this.Controls.Add(this.customerNameLable);
            this.Controls.Add(this.coustomerNameValue);
            this.Controls.Add(this.CarRentalLable);
            this.Name = "rentalForm";
            this.Text = "Rent a Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarRentalLable;
        private System.Windows.Forms.TextBox coustomerNameValue;
        private System.Windows.Forms.Label customerNameLable;
        private System.Windows.Forms.DateTimePicker pickUpDateTimePicker1;
        private System.Windows.Forms.DateTimePicker leaveDateTimePicker2;
        private System.Windows.Forms.Label leveDateLable;
        private System.Windows.Forms.Label pickUpDateLable;
        private System.Windows.Forms.ComboBox typeOfCarValue;
        private System.Windows.Forms.Label typeOfCarLable;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox costValue;
        private System.Windows.Forms.Label costLable;
        private System.Windows.Forms.Button button1;
    }
}

