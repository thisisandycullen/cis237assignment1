//WINEITEMCOLLECTION
//THIS CLASS CONTROLS THE COLLECTION OF WINE ITEMS (ITEMS ARE HELD IN AN ARRAY)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        //variables
        int arrayLength;
        private WineItem[] wineItemList;
        
        //constructor
        public WineItemCollection()
        {
            wineItemList = new WineItem[4100];
            arrayLength = 0;
        }

        //methods
        public string displayItemList()
        {   //this method prints the full list of wine items
            string outputString = string.Empty;

            foreach (WineItem wineItem in wineItemList)
            {
                if (wineItem != null)
                {
                    outputString += wineItem.ShowList() + Environment.NewLine;
                }
            }

            return outputString;
        }

        public void addNewItem(WineItem wineItem)
        {   //this method adds a wine item to the list array
            wineItemList[arrayLength] = wineItem;

            arrayLength += 1;
        }

        public string searchString(string inputID)
        {   //this method takes user input and searches each WineItem's ID value to find a match,
            //then returns the matched WineItem
            string searchResults = string.Empty;

            int searchLength = 0;

            //the program will stop searching when a value is found
            while (searchLength < wineItemList.Length)
            {
                try
                {
                    if (wineItemList[searchLength].ID == inputID)
                    {
                        searchResults = "{0}Item found:{0}" +
                                        wineItemList[searchLength].ID + ", " +
                                        wineItemList[searchLength].Name +", " +
                                        wineItemList[searchLength].Pack;

                        searchLength = wineItemList.Length;
                    }
                    else
                    {
                        searchLength += 1;
                    }
                }
                catch
                {   //if no match is found...
                    searchResults = "Item ID " + inputID + " not found.";
                    searchLength = wineItemList.Length;
                }
            }

            return searchResults;
        }
    } //END OF CLASS
} //END OF NAMESPACE
