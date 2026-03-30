using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementSystem
{
    public abstract class Asset
    {
        protected Asset(string brand, string model, double price,
            DateTime purchaseDate, Office office)
        {
            Brand = brand;
            Model = model;
            Price = price;
            PurchaseDate = purchaseDate;
            Office = office;
        }

        public abstract string Type { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Office Office { get; set; }
        public string Country => Office?.Country;

        //public int LifeSpanYears { get; set; }
        
        
        public DateTime GetEndOfLifeDate () 
        { return PurchaseDate.AddYears(3);
        }

        public enum AssetStatus
        {
            Red,
            Orange,
            Yellow,
            Active
        }
        public AssetStatus GetStatus()
        {
            DateTime endDate = GetEndOfLifeDate();
            TimeSpan remainingTime = endDate - DateTime.UtcNow;
            if (remainingTime.Days <= 0)
                return AssetStatus.Red;
            else if (remainingTime.Days <= 90)
                return AssetStatus.Orange;
            else if (remainingTime.Days <= 180)
                return AssetStatus.Yellow;
            else
                return AssetStatus.Active;
        }




    }
}
