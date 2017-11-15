using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_tutoring
{
    class SuperHero
    {
        private string secretIdentity;
        private bool hasCape;
        private int strengthLevel;
        private string archnemesis;
        //planetOfOrigin under invisibility cloak

        //properties
        //public string SecretIdentity
        //{
        //    get { return this.secretIdentity; }
        //    set { this.secretIdentity = value; }
        //}

        // same way as the above method but in short hand
        public string SecretIdentity { get; set; }
        public bool HasCape { get; set; }
        public string StrengthLevel { get; set; }
        public string Archnemesis { get; set; }

        //constructors
        public SuperHero()
        {

        }

        public SuperHero(string secretIdentity, bool hasCape)
        {
            this.secretIdentity = SecretIdentity;
            this.hasCape = hasCape;
            strengthLevel = 16;
            archnemesis = "Lex Luther";
        }
    }
}
