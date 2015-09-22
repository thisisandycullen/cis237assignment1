//CSVPROCESSOR
//THIS CLASS HANDLES THE LOADING OF THE CSV FILE. THE LOADLIST METHOD SAVES EACH ITEM AS A WINEITEM.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        //variables
        bool loadFinished = false;

        //empty default constructor
        public CSVProcessor()
        {

        }

        //methods
        public void loadList(WineItemCollection wICollection)
        {   //this method reads the csv file and splits items at each comma, saving values as WineItem values
            if (!loadFinished)  //ensures the list is only loaded once
            {   
                StreamReader streamreader = new StreamReader("..\\..\\..\\datafiles\\WineList.csv");

                string[] splitter;

                while (!streamreader.EndOfStream)
                {
                    splitter = streamreader.ReadLine().Split(',');

                    WineItem wineItem = new WineItem(splitter[0], splitter[1], splitter[2]);
                    wICollection.addNewItem(wineItem);
                }

                loadFinished = true;    //marks the list as loaded

            }
        }
    } //END OF CLASS
} //END OF NAMESPACE
