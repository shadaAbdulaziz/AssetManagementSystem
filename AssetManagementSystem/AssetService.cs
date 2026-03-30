using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementSystem
{
    public class AssetService
    {
        private List<Asset> assets = new List<Asset>();

        public AssetService()
        {
            // offices
            Office swedenOffice = new Office("Sweden", "SEK");
            Office germanyOffice = new Office("Germany", "EUR");
            Office usaOffice = new Office("USA", "USD");

            
            //  Devices
            
            assets.Add(new Mobile("Samsung", "S22", 1100, new DateTime(2023, 6, 27), swedenOffice));
            assets.Add(new Mobile("Samsung", "S21", 900, new DateTime(2022, 1, 15), germanyOffice));

            assets.Add(new Computer("Dell", "XPS 13", 2000, new DateTime(2026, 3, 15), usaOffice));
            assets.Add(new Computer("Dell", "XPS 15", 2500, new DateTime(2022, 7, 10), germanyOffice));

            assets.Add(new Mobile("Google", "Pixel 7", 950, new DateTime(2023, 6, 20), usaOffice));
            assets.Add(new Mobile("OnePlus", "10", 850, new DateTime(2024, 9, 30), swedenOffice));
            assets.Add(new Mobile("Xiaomi", "13", 800, new DateTime(2023, 3, 12), germanyOffice));

            assets.Add(new Mobile("Apple", "iPhone 13", 1200, new DateTime(2022, 5, 1), usaOffice));
            assets.Add(new Mobile("Apple", "iPhone 12", 1000, new DateTime(2023, 6, 26), germanyOffice));


            assets.Add(new Computer("HP", "Pavilion", 1500, new DateTime(2025, 8, 20), swedenOffice));
            assets.Add(new Computer("HP", "Envy", 1700, new DateTime(2021, 11, 5), germanyOffice));

            assets.Add(new Computer("Apple", "MacBook Air", 1800, new DateTime(2023, 1, 25), usaOffice));
            assets.Add(new Computer("Apple", "MacBook Pro", 3000, new DateTime(2022, 6, 18), usaOffice));

            assets.Add(new Computer("Lenovo", "ThinkPad", 1600, new DateTime(2024, 9, 9), swedenOffice));
        }

        
        // Adding Asset       
        public void AddAsset(Asset asset)
        {
            assets.Add(asset);
        }

        // Deleting Asset     
        public void DeleteAsset(Asset asset)
        {
            assets.Remove(asset);
        }

        // Get all Assets        
        public List<Asset> GetAllAssets()
        {
            return assets;
        }

        

        
        
    }
}
