using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAd
{
    public class AutoAdClass
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        public string Description { get; set; }

        public static  List<string> Images = new List<string>();

        public enum AdType
        {
            Rent = 1,
            Sell = 2
        }

       
        public string images()
        {
            string images = "";
            foreach(var image in Images)
            {
                images += image;
                images += ";";
            }
            return images;
        }
        
        public void Add(string filepath) 
        {
            if (Images.Contains(filepath))
                throw new Exception($"[{filepath}] already exist!");

            Images.Add(filepath);
            
        }

        public static  void RemoveImages()
        {
            Images.Clear(); 
            
        }


        
    }
}
