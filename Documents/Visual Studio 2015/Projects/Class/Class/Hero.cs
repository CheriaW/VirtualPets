using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Hero
    {
        //fields
        private string strong;
        private string courage;
        private double weight;
        private int speed;

        public string Strong
        {
            get { return this.strong; }
            set { this.strong = value; }
        }
        public string Courage
        {
            get { return this.courage; }
            set { this.courage = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        //constructors
        public Hero()
        {

        }

        //overloaded constructors
        public Hero(string strong, string courage)
        {
            this.strong = strong;
            this.courage = courage;
        }
        public Hero(double weight, int speed)
        {
            this.weight = weight;
            this.speed = speed;
        }
        //methods
        public void Bananas()
        {
            strong = "Can lift a hundred trains.";

        }
        public void Puppies()
        {
            courage = "Bravely faces villians.";
        }
        public void Gain()
        {
            weight += 5.0;
        }
        public void Run()
        {
            speed = 100;
        }
    }
}
