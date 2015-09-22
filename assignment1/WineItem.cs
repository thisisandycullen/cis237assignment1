//WINE ITEM
//THIS CLASS DEFINES THE THREE PROPERTIES OF A WINE ITEM: ID, NAME, AND PACK (VOLUME)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        //variables
        private string id;
        private string name;
        private string pack;

        //constructor
        public WineItem(string id, string name, string pack)
        {
            this.id = id;
            this.name = name;
            this.pack = pack;
        }

        //properties
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Pack
        {
            get
            {
                return this.pack;
            }

            set
            {
                this.pack = value;
            }
        }

        //methods
        public override string ToString() //overrides ToString() method
        {   //this method assembles a wine item string and returns it for output
            string wineItemString = string.Empty;

            wineItemString += this.id + ", ";
            wineItemString += this.name + ", ";
            wineItemString += this.pack;

            return wineItemString;
        }
    } //END OF CLASS
} //END OF NAMESPACE
