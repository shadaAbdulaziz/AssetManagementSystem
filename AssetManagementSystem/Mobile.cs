using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementSystem
{
    public class Mobile : Asset
    {
        public override string Type => "Mobile";
        public Mobile(string brand, string model, double price, DateTime purchaseDate, Office office) 
            : base(brand, model, price, purchaseDate, office)
        {
        }

        //private const int DefaultLifeSpan = 3;
       

        
    }
}
