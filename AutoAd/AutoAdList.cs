using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace AutoAd
{
    public class AutoAdList
    {
        public static List<AutoAdClass> Ads { get; private set; }

        public AutoAdList()
        {
            Ads = new List<AutoAdClass>();
           
        }

        #region "Sort and order by methods"
        public List<AutoAdClass> PriceSort(double min,double max)
        {
            var result = Ads.Where(x => x.Price >= min && x.Price <= max).ToList();
            return result;
        }

        public List<AutoAdClass> YearSort(double min, double max)
        {
            var result = Ads.Where(x => x.Year >= min && x.Year <= max).ToList();
            return result;
        }

        public List<AutoAdClass> OrderByPrice()
        {
            var result =Ads.OrderBy(x => x.Price).ToList();
            return result;
        }

        public List<AutoAdClass> OrderByYear()
        {
            var result = Ads.OrderBy(x => x.Year).ToList();
            return result;
        }

        public List<AutoAdClass> SearchByModel(string model)
        {
            var result = Ads.Where(x => x.Model == model).ToList();
            return result;
            
        }

        public List<AutoAdClass> OnlyAds(string adtype)
        {
            var result = Ads.Where(x => x.Type == adtype).ToList();
            return result;
        }
        #endregion

        public void AddImagePath (string filePath)
        {
            AutoAdClass.Images.Add(filePath);
        }

        public void RemoveImage(string filepath)
        {
            AutoAdClass.Images.Remove(filepath);
        }

        public void DeleteImagesPath()
        {
            AutoAdClass.RemoveImages();
        }
        
        public AutoAdClass SearchId(int id)
        {
            foreach(var ad in Ads)
            {
                if (ad.Id == id)
                    return ad;
            }
            return null;
        }
        
        public void Add(AutoAdClass autoAd)
        {
            if (Ads.Contains(autoAd))
                throw new Exception($"[{autoAd}] already exist!");

            Ads.Add(autoAd);
        }

        public void Remove(AutoAdClass autoAd)
        {
            if (!Ads.Contains(autoAd))
                throw new Exception($"[{autoAd}] does not exist!");

            Ads.Remove(autoAd);
        }

        public void MoveImages(string filePath,AutoAdClass ad)
        {
            string content = ad.images();
            var images = content.Split(';');
           
            foreach (var image in images)
            {
                if (string.IsNullOrEmpty(image)) break;
                var file = Path.GetFileName(image);
                
                file = Path.Combine(filePath,file);
                File.Copy(image, file);
            }
            
        }
        
        public void SaveOnDisk(string filePath,AutoAdClass ad)
        {
            string filename = ad.Id + ".json";
            
            string content = JsonConvert.SerializeObject(ad);
            File.WriteAllText(Path.Combine(filePath, filename), content);
            filename = ad.Id + "images.json";
           
            MoveImages(filePath,ad);
            
        }

        public void LoadFromDisk(string filePathToParentFolder)
        {
            string[] dirs = Directory.GetDirectories(filePathToParentFolder, "*");
            foreach(string dir in dirs)
            {
                var d = new DirectoryInfo(dir);
                var content = File.ReadAllText(Path.Combine(dir, $"{d.Name}.json"));
                AutoAdClass ad = JsonConvert.DeserializeObject<AutoAdClass>(content);
                Ads.Add(ad);
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(Ads);
        }

        public void RemoveAd(string Id,string Path)
        {
            
            string[] dirs = Directory.GetDirectories(Path, Id);
            
                Directory.Delete(dirs[0], true);
            
        }

        
    }
}
