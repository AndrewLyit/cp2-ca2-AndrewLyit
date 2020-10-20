using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Item
    {
        //Armour class Fields
        private string itemName_;  //Cannot be empty
        private double itemWeight_; //Must be in range [0.001..60] kg
        private double itemValue_; //Must be in range [0.01..100]


        //Item class Properties
        public string ItemName
        {
            //Set or Get the item name as required
            //Throw out of range exception if invalid name given
            get { return itemName_; }
            set
            {
                if (value.Length > 0)
                    itemName_ = value;

                if (value.Length <= 0)
                {
                    throw new ArgumentException("Item Name cannot be empty");
                    //ArgumentException
                }
            }
        }

        public double ItemWeight
        {
            //Set or Get the item weight as required
            //Throw out of range exception if invalid weight given
            get { return itemWeight_; }
            set
            {
                if (value > 0)
                    itemWeight_ = value;


                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Item weight cannot be <=0");

                }
            }
        }

        public double ItemValue
        {
            //Set or Get the item value as required
            //Throw out of range exception if invalid value given
            get { return itemValue_; }
            set
            {
                if (value >= 0)
                    itemValue_ = value;

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Item value cannot be <0");
                }
            }
        }

        //Item class Methods

        /// <summary>
        /// The default constructor for <c>Item</c> should create an item object with the following default values:
        /// ItemName = "Magic cap";
        /// ItemValue = 100;
        /// ItemWeight = 0.2;
        /// </summary>
        public Item()
        {
            //Initialise the item object with the default values
            ItemName = "Magic cap";
            ItemValue = 100;
            ItemWeight = 0.2;
        }

        /// <summary>
        /// The non-default constructor for <c>Item</c> should initialise the new item object
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="itemValue"></param>
        /// <param name="itemweight"></param>
        public Item(string itemName, int itemValue, double itemWeight)
        {
            //Initialise the item object with the arguments
            ItemName = itemName;
            ItemValue = itemValue;
            ItemWeight = itemWeight;
        }
        /// <summary>
        /// Returns a string formatted as follows
        /// itemName_ worth: itemValue_ gold coins
        /// </summary>
        /// <returns></returns>
        //public string ToString()
        //{
        //    //ToDo Implement the method as described in the summary. The formatting has to match the example above
        //    string output = itemName_ + ", worth: " + itemValue_.ToString() + " gold coins";
        //    return output; 
        //}
    }
}
