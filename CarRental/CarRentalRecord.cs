//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRentalRecord
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<System.DateTime> DateOut { get; set; }
        public Nullable<System.DateTime> DateIn { get; set; }
        public Nullable<int> CarType { get; set; }
    
        public virtual TypesOfCar TypesOfCar { get; set; }
    }
}
