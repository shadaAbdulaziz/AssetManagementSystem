using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementSystem
{
    public class Office
    {
        public Office(string country, string currency)
        {
            Country = country;
            Currency = currency;
        }

        public string Country { get; set; }
        public string Currency { get; set; }
        // This method to covert the currency
        public double ConvertToUSD(double amount, string currency)
        {
            switch (currency)
            {
                case "EUR":
                    return amount * 0.92;   

                case "SEK":
                    return amount * 9.34;

                case "USD":
                    return amount;

                default:
                    return amount;
            }
        }


    }
}
