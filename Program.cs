using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecare
{
    class Program
    {
        static void Main(string[] args)
        {
            //MakeCare
            Car BMW = new Car(10000, "black", 4.5, "M-Series");
            var features = new List<Feature>
            {
                new Feature() { Name="Bluetooth", Value="Sony"},
                new Feature() { Name="HeatedSeat", Value="Exists"},

            };

            BMW.OtherFeatures = features;

            //CheckFeature

            Feature BMWCheckFeature = BMW.OtherFeatures.Find(x => x.Name.Contains("Bluetooth"));
            if (BMWCheckFeature.Value == "Sony")
            {
                Console.WriteLine("Yes, BMW has Sony Bluetooth option");
            }
        }
        
    }
}
