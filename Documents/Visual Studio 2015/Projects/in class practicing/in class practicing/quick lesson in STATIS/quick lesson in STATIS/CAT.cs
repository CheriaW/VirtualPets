using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_lesson_in_STATIS
{
    class CAT
    {
        private int catCount;

        public int CatCount
        {
        get {return this.catCount; }
        set {this.catCount = value; }
        }
        public CAT()
        {

        }
        public void WarCry()
        {
            Console.WriteLine("We are an army of " + catCount + " cats.");
        }
    }
}
