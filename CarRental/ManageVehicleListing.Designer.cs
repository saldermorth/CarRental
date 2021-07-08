
namespace CarRental
{
    partial class ManageVehicleListing
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
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.CarRentalLable = new System.Windows.Forms.Label();
            this.addNewCarButton = new System.Windows.Forms.Button();
            this.editCarButton = new System.Windows.Forms.Button();
            this.deleteCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(12, 116);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.Size = new System.Drawing.Size(228, 159);
            this.gvVehicleList.TabIndex = 0;
            // 
            // CarRentalLable
            // 
            this.CarRentalLable.AutoSize = true;
            this.CarRentalLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRentalLable.Location = new System.Drawing.Point(192, 28);
            this.CarRentalLable.Name = "CarRentalLable";
            this.CarRentalLable.Size = new System.Drawing.Size(427, 42);
            this.CarRentalLable.TabIndex = 1;
            this.CarRentalLable.Text = "Manage Vehicle Listing";
            // 
            // addNewCarButton
            // 
            this.addNewCarButton.Location = new System.Drawing.Point(336, 130);
            this.addNewCarButton.Name = "addNewCarButton";
            this.addNewCarButton.Size = new System.Drawing.Size(105, 38);
            this.addNewCarButton.TabIndex = 2;
            this.addNewCarButton.Text = "Add New Car";
            this.addNewCarButton.UseVisualStyleBackColor = true;
            this.addNewCarButton.Click += new System.EventHandler(this.addNewCarButton_Click);
            // 
            // editCarButton
            // 
            this.editCarButton.Location = new System.Drawing.Point(336, 192);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(105, 38);
            this.editCarButton.TabIndex = 3;
            this.editCarButton.Text = "Edit Car";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Location = new System.Drawing.Point(336, 254);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(105, 38);
            this.deleteCarButton.TabIndex = 4;
            this.deleteCarButton.Text = "Delete Car";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.addNewCarButton);
            this.Controls.Add(this.CarRentalLable);
            this.Controls.Add(this.gvVehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "ManageVehicleListing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label CarRentalLable;
        private System.Windows.Forms.Button addNewCarButton;
        private System.Windows.Forms.Button editCarButton;
        private System.Windows.Forms.Button deleteCarButton;
    }
}