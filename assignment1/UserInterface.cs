//USER INTERFACE
//USER INPUT AND OUTPUT IS HANDLED WITHIN THIS CLASS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //variables and objects
        WineItemCollection wineItemCollection;
        //creates a CSVProcessor object
        CSVProcessor csvProcessor = new CSVProcessor();

        //the text menu is held in this string
        string menuString = "{0}Select an action." +
                        "{0}"+
                        "{0}1 - Show all items"+
                        "{0}2 - Add item to list"+
                        "{0}3 - Search item by ID"+
                        "{0}4 - Close program"+
                        "{0}";

        //constructor
        public UserInterface(WineItemCollection wICollection)
        {
            this.wineItemCollection = wICollection;
        }

        //methods
        public void loadList()
        {   //this method loads the wine list with the csv processor
            csvProcessor.loadList(wineItemCollection);
        }

        public void displayTextMenu()
        {   //this method prints the options menu to the console
            Console.WriteLine(menuString, Environment.NewLine);

            string userInput = Console.ReadLine().ToString();

            switch (userInput)
            {
                case "1":
                    listItems();
                    break;
                case "2":
                    addItem();
                    break;
                case "3":
                    searchID(); 
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

            displayTextMenu();  //show the text menu again when finished
        }

        public void listItems()
        {   //this method prints the item list to the console
            Console.WriteLine(wineItemCollection.displayItemList());
        }

        public void addItem()
        {   //this method walks the user through the addition of an item
            Console.WriteLine("{0}Enter the new item's ID:{0}", Environment.NewLine);
            string addItemID = Console.ReadLine().ToString();

            Console.WriteLine("{0}Enter the new item's name:{0}", Environment.NewLine);
            string addItemName = Console.ReadLine().ToString();

            Console.WriteLine("{0}Enter the new item's pack/volume:{0}", Environment.NewLine);
            string addItemPack = Console.ReadLine().ToString();

            WineItem addedItem = new WineItem(addItemID, addItemName, addItemPack);
            wineItemCollection.addNewItem(addedItem);

            Console.WriteLine("{0}Item added succesfully!", Environment.NewLine);

        }

        public void searchID()
        {   //this method allows the user to enter an ID to search within the WineItemCollection
            Console.WriteLine("{0}Enter the ID of the item you are searching for:{0}", Environment.NewLine);

            string userInput = Console.ReadLine().ToString();

            if (userInput != string.Empty)
            {
                Console.WriteLine(wineItemCollection.searchString(userInput), Environment.NewLine);
            }
            else
            {
                searchID();
            }
        }
    } //END OF CLASS
} //END OF NAMESPACE
