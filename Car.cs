using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecare
{
    class Car
    {
        private string model;
        private int price;
        private string color;
        private double safetyRating;
        private List<Feature> features;
       

        public Car(int _price, string _color, double _safetyRating,string _model)
        {
            this.model = _model;
            this.price = _price;
            this.color = _color;
            this.safetyRating = _safetyRating;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double SafetyRating
        {
            get { return safetyRating; }
            set { safetyRating = value; }
        }

        public List<Feature> OtherFeatures
        {
            get { return features; }
            set { features = value; }
        }
    }

    public class Feature
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
