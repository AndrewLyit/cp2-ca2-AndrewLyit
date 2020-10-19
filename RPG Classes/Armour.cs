/*
* Armour.cs
*
* Version information v0.1
* Author: Dr. Shane Wilson
* Date: 05/02/2020
* Description: Armour class for Armour that characters may have
* Copyright notice
*/

/// <summary> Class <c> Armour </c> implements a Armour object for RGP game characters
/// </summary>

using RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    //Enumeration for armour types
    public enum ArmourTypes { Cardboard, Leather, Wood, Iron, Steel };

    public class Armour : Item
    {
        //Armour class Fields
        private int armourDefence_; //The defensive value of the armour. Must be in range [1..100] 
        private int armourHealth_; //The health of the armour. Must be in range [1..100]
        private ArmourTypes armourType_;

        //Armour class Properties
        public string ArmourName
        {
            //Set or Get the armour name as required
            //Throw out of range exception if invalid name given
            //get { return armourName_; }
            get { return base.ItemName; }
            set
            {
                base.ItemName = value;
            }
}

        public double ArmourWeight
        {
            //Set or Get the armour weight as required
            //Throw out of range exception if invalid weight given
            get { return base.ItemWeight; }
            set
            {
                if (value > 0)
                    base.ItemWeight = value;


                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Armour weight cannot be <=0");

                }
            }
        }

        public double ArmourValue
        {
            //Set or Get the armour value as required
            //Throw out of range exception if invalid value given
            get { return base.ItemValue; }
            set
            {
                if (value >= 0)
                    base.ItemWeight= value;

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Armour value cannot be <0");
                }
            }
        }

        public int ArmourDefence
        {
            //Set or Get the armour defence value as required
            //Throw out of range exception if invalid defence given
            get { return armourDefence_; }
            set
            {
                if (value >= 0)
                    armourDefence_ = value;

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Armour defence cannot be <0");
                }
            }
        }

        public int ArmourHealth
        {
            //Set or Get the armour health value as required
            //Throw out of range exception if invalid health given
            get { return armourHealth_; }
            set
            {
                if (value > 0)
                    armourHealth_ = value;

                if ((value <= 0) || (value >100))
                {
                    throw new ArgumentOutOfRangeException("Armour health cannot be <=0");
                }
            }
        }

        public ArmourTypes ArmourType
        {
            //Set or Get the armour name as required
            get => armourType_;
            set
            {
                armourType_ = value;
            }
        }


        //Armour class Methods

        /// <summary>
        /// The default constructor for <c>Armour</c> should create an armour object
        /// with the following default values:
        /// ArmourName = "Cardboard box";
        /// ArmourValue = 1;
        /// ArmourWeight = 0.2;
        /// ArmourDefence = 0;
        /// ArmourHealth = 100;
        /// ArmourType = ArmourTypes.Cardboard;
        /// </summary>
        public Armour()
        {
            //Initialise the armour object with the default values
            ArmourName = "Cardboard box";
            ArmourValue = 1;
            ArmourWeight = 0.2;
            ArmourDefence = 0;
            ArmourHealth = 100;
            ArmourType = ArmourTypes.Cardboard;
        }


        /// <summary>
        /// The non-default constructor for <c>Armour</c> should initialise the new armour object
        /// </summary>
        /// <param name="armourName"></param>
        /// <param name="armourValue"></param>
        /// <param name="armourweight"></param>
        /// <param name="defence"></param>
        /// <param name="armourHealth"></param>
        /// <param name="type"></param>
        public  Armour(string armourName, int armourValue, double armourweight, int defence, int armourHealth, ArmourTypes type)
        {
            //Initialise the armour object with the arguments
            ArmourName = armourName;
            ArmourValue = armourValue;
            ArmourWeight = armourweight;
            ArmourDefence = defence;
            ArmourHealth = armourHealth;
            ArmourType = type;
        }


    }
}
