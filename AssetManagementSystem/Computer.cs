using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementSystem
{
    public class Computer : Asset
    {
        public override string Type => "Computer";
        public Computer(string brand, string model, double price, DateTime purchaseDate, Office office)
            : base(brand, model, price, purchaseDate, office)
        {
        }

        

        
    }
}
