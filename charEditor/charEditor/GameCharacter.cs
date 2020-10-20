/*
* GameCharacter.cs - my code
*
* Version information v0.1
* Author: Dr. Shane Wilson
* Date: 04/02/2020
* Description: Acts as the base class for game character RPG classes
* Copyright notice
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public enum CharacterState { Idle, Running, Sleeping, Walking, Defending, Dead };
    
    /// <summary> Class <c> GameCharacter </c> implements the base class for a 
    ///  simple RGP game character
    /// </summary>

    abstract public class GameCharacter
    //public class GameCharacter
    {
        //Class fields (data members)
        private static int numberOfCharacters_ = 0;


        private string characterName_; //Cannot be empty
        private int health_; //Must be in range [0..100]. If 0 then character state should be dead
        private int characterExperience_; //Must be in range [0..100]. 
        private double weightLimit_; ////Must be in range [1..60]
        private double totalWeightOfItems_; //Cannot exceed weightLimit
        private int equippedWeapon_; //range -1 to count-1 of items in weapon list. -1 means no weappon equipped
        private int equippedArmour_; //range -1 to count-1 of items in armour list. -1 means no armour equipped
        private List<Item> inventory_; //Inventory of weapons, armour and items
        //List<Armour> armour_; //List of armour items //No longer needed as we use a list of items inventory_
        //List<Weapon> weapons_; //list of weapons //No longer needed as we use a list of items inventory_
        private int food_; //Must be >=0
        private CharacterState characterState_;
           
        //Class properties
        public int NumberOfCharacters
        {
            get => numberOfCharacters_;
        }

        public string CharacterName
        {
            get { return characterName_; }
            set { if (value.Length < 1)
                    throw new ArgumentOutOfRangeException(
                        $"Character name must be at least one character long");

                characterName_ = value;
            }
        }

        public int Health
        {
            //get { return health_; }
            get => health_;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                        $"health cannot be negative");

                health_ = value;
            }
        }

        public int CharacterExperience
        {
            get { return characterExperience_; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                        $"character experience cannot be negative");

                characterExperience_ = value;
            }
        }

        public double WeightLimit
        {
            get { return weightLimit_; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                        $"Character weight limit cannot be negative");

                weightLimit_ = value;
            }
        }

        public int EquippedWeapon
        {
            get { return equippedWeapon_; }
            set
            {
                //if ((value >= -1) && (value <= weapons_.Count - 1)){
                if ((value >= -1) && (value <= this.inventory_.Count - 1))
                {
                    //Test to see if it is a weapon
                    if (this.inventory_[value].GetType() == typeof(Weapon))
                    {
                        equippedWeapon_ = value;
                    }
                    else
                        throw new ArgumentOutOfRangeException(
                     $"Value of equipped weapon supplied value does not index a weapon");

                }
                //if((value <-1) || (value>this.weapons_.Count-1))
                if ((value < -1) || (value > this.inventory_.Count - 1))
                    throw new ArgumentOutOfRangeException(
                     $"Value of equipped weapon cannot be <-1 or > than number of items-1");

            }
        }

        public int EquippedArmour
        {
            get { return equippedArmour_; }
            set
            {
                //if ((value >= -1) && (value <= weapons_.Count - 1)){
                if ((value >= -1) && (value <= this.inventory_.Count - 1))
                {
                    //Test to see if it is a weapon
                    if (this.inventory_[value].GetType() == typeof(Armour))
                    {
                        equippedArmour_ = value;
                    }
                    else
                        throw new ArgumentOutOfRangeException(
                     $"Value of equipped armour supplied value does not index a piece of armour");

                }
                if ((value < -1) || (value > this.inventory_.Count - 1))
                    throw new ArgumentOutOfRangeException(
                     $"Value of equipped armour cannot be <-1 or > than number of items-1");

            }
        }

        //Added to the spec, needs to be read only
        public double TotalWeightOfItems
        {
            get { return totalWeightOfItems_; }
        }

        public int Food
        {
            get { return food_; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        $"Amount of food cannot be negative");
                }
                if ((value * 0.2) + totalWeightOfItems_ < weightLimit_)
                {
                    //The old amount of food should be removed from weight before setting the new 
                    //weight and food amount
                    int old_food_amount = food_;
                    totalWeightOfItems_ -= old_food_amount * 0.2;
                    if (totalWeightOfItems_ < 0)
                    {
                        totalWeightOfItems_ = 0.0;
                    }
                    food_ = value;
                    totalWeightOfItems_ += value * 0.2;
                }

            }
        }

        public CharacterState CharState
        {
            get => characterState_;
            set
            {
                characterState_ = value;
            }
        }

        //Default constructor
        /// <summary>
        /// Method <c>GameCharacter</c> initialises the game character with the following default values
        /// name="Ninja", Health=100, food=20, weightLimit=30, no armour or weapon equippedm totalweight =4
        /// </summary>
        public GameCharacter()
        {
            numberOfCharacters_++;
            /* The default constructor should set default values for object's data members */
            characterName_ = "Ninja";
            characterExperience_ = 0;
            health_ = 100;
            food_ = 20;
            weightLimit_ = 30;
            totalWeightOfItems_ = 4;
            equippedWeapon_ = -1; //-1 represents nothing equipped 
            equippedArmour_ = -1;
            //armour_ = new List<Armour>(); //***no longer needed
            //weapons_ = new List<Weapon>(); //***no longer needed
            inventory_ = new List<Item>(); 
        }

        //Non default constructor
        public GameCharacter(string name, int exp, int health, int food, double weightLimit, CharacterState state)
        {
            /* The non-default constructor should set values for object's data members */
            if (name.Length < 1)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(name)} must be one character long at least");
            characterName_ = name;

            if (exp < 1)
                throw new ArgumentOutOfRangeException(
                    $"Character experience must be one character long at least");
            characterExperience_ = exp;

            if (health < 0)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(health )} cannot be less than 0");
            health_= health;

            if (food < 0)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(food)} cannot be less than 0");
            food_ = food;
            totalWeightOfItems_ += food_ * 0.2;

            if (weightLimit < 0)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(weightLimit)} cannot be less than 0");
            weightLimit_ = weightLimit;

            equippedWeapon_ = -1; //-1 represents nothing equipped 
            equippedArmour_ = -1;

            characterState_ = state;
            numberOfCharacters_++;
            //armour_ = new List<Armour>(); //***no longer needed
            //weapons_ = new List<Weapon>();//***no longer needed
            inventory_ = new List<Item>(); 
        }

        /// <summary>
        ///  Method <c>AddFood</c> adds an amount of food to the character. Each unit of food weighs 200g
        ///  totalWeightOfItems should not exceed weightLimit. If the character cannot carry any item then
        ///  it isn't added to their inventory.
        /// </summary>
        /// <param name="amount"></param>
        public void AddFood(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(
                    $"{nameof(amount)} cannot be <0 ");
            }

            if ((amount*0.2)+ totalWeightOfItems_ < weightLimit_)
            {
                totalWeightOfItems_ += amount * 0.2;
                food_ += amount;
            }
            
        }
 
        /// <summary>
        ///  Method <c>Eat</c> consumes 1 unit of food if available and restores 5 units of health. 
        ///  Health should not exceed 100 which is full health for the character
        /// </summary>
        public void Eat()
        {
            //Consume 1 food and add 5 units of health. Reduce totalWeightOfItems accordingly
            if (food_ > 0)
            {
                food_ -= 1;
                health_ += 5;
                totalWeightOfItems_ -= 0.2;
                if (health_ > 100)
                    health_ = 100; //health should not exceed 100
            }
        }

        /// <summary>
        ///  Method <c>Eat</c> consumes 1 unit of food if available and restores 5 units of health. 
        ///  Health should not exceed 100 which is full health for the character
        /// </summary>
        public void Eat(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(
                    $"{nameof(amount)} cannot be <0 ");
            }

            //Consume 1 food and add 5 units of health. Reduce totalWeightOfItems accordingly
            if (food_ > amount)
            {
                health_ += 5 * amount;
                totalWeightOfItems_ -= amount * 0.2;
                food_ -= amount;
                if (health_ > 100)
                    health_ = 100; //health should not exceed 100

            }
            else
            {
                health_ += 5 * food_;
                totalWeightOfItems_ -= food_* 0.2;
                if (health_ > 100)
                    health_ = 100; //health should not exceed 100
                food_ = 0;
            }
        }
        /// <summary>
        /// Method <c>Attack</c> should print out "CharacterName is attacking param.CharacterName"
        /// The health of the character being attacked should be reduced by 10
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        //public virtual bool Attack(GameCharacter character)
        public virtual bool Attack(GameCharacter character)
        {
            Console.WriteLine("Attacking from GameCharacter");
            Console.WriteLine(CharacterName + " is attacking " + character.CharacterName);
            if((character.Health - 10) <= 0)
            {
                character.Health = 0;
                character.CharState = CharacterState.Dead;
            }
            else
            {
                character.Health -= 10;
            }
            return true;
            
        }

        /// <summary>
        /// Method <c>Defend</c> equips the armour at armourIndex and prints the message
        /// "<CharacterName> is defending with a <NameofArmourItem>"
        /// If no armour is equipped then the armour name should be "wry smile"
        /// </summary>
        /// <param name="armour"></param>
        public void Defend(int armourIndex)
        {
            //armourIndex in range from [0 to armour_list.count-1]
            //Get the name of the item the character is defending with 
            string itemName = "just a wry smile";
            if ((armourIndex >= 0) && (armourIndex <= inventory_.Count))
            {
                //itemName = armour_[equippedArmour_].ArmourName; 
                //Check to see if the index points to a piece of armour
                if (this.inventory_[armourIndex].GetType() == typeof(Armour))
                {
                    equippedArmour_ = armourIndex;
                    itemName = inventory_[armourIndex].ItemName;
                }

            }

            //Console.WriteLine(CharacterName + " is defending with a ");
            Console.WriteLine($"{CharacterName} is defending with a {itemName}");

            //Regardless change the state to defending
            characterState_ = CharacterState.Defending;
        }
     

        public void Walk()
        {
            Console.WriteLine(CharacterName + " is walking");
            characterState_ = CharacterState.Walking;
        }

        public void Run()
        {
            Console.WriteLine(CharacterName + " is running");
            characterState_ = CharacterState.Running;
        }

        public void Sleep()
        {
            Console.WriteLine(CharacterName + " is sleeping");
            characterState_ = CharacterState.Sleeping;
        }

        public bool PicKUpItem(Item item)
        {
            if (totalWeightOfItems_ + item.ItemWeight <= weightLimit_)
            {
                //Add the item
                inventory_.Add(item);
                totalWeightOfItems_ += item.ItemWeight;
            }
            return true;
        }

        /// <summary>
        /// Removes the item from the inventory_ List at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DropItem(int index)
        {
            if ((inventory_.Count > index) && (index >= 0))
            {
                //update the weight of items carried
                this.totalWeightOfItems_ -= inventory_[index].ItemWeight; //Test for this
                inventory_.RemoveAt(index);
                //If they are dropping an equipped item, set equipped to -1
                if (index == equippedArmour_)
                {
                    equippedArmour_ = -1;
                }
                if (index == equippedWeapon_)
                {
                    equippedWeapon_ = -1;
                }              
                return true;
            }

                //Didn't drop item
                return false;
        }

        /// <summary>
        /// Removes the item from the inventory_ List 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool DropItem(Item item)
        {
            //loop through the vector and find the armour, exact match
            for (int index = 0; index < inventory_.Count; ++index)
            {
                if (inventory_[index].ItemName == item.ItemName)
                {
                    if (inventory_[index].ItemValue == item.ItemValue)
                    {
                        if (inventory_[index].ItemWeight == item.ItemWeight)
                        {
                            //If they are dropping an equipped item, set equipped to -1
                            if (index == equippedArmour_)
                            {
                                equippedArmour_ = -1;
                            }
                            if (index == equippedWeapon_)
                            {
                                equippedWeapon_ = -1;
                            }

                            inventory_.RemoveAt(index);
                            //update the weight of items carried
                            this.totalWeightOfItems_ -= item.ItemWeight; //Test for this
                            return true;
                        //        }
                        //    }
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Returns the item from the inventory_ List at index 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Item GetItem(int index)
        {
            //armourIndex in range from [0 to armour_list.count-1]

            if ((inventory_.Count > index) && (index >= 0))
            {
                return inventory_[index];
            }
            //Return an empty armour object with name "EmptyArmour" if the index is invaid
            Item temp = new Item();
            temp.ItemName = "EmptyItem";
            return temp;
        }

               
        /// <summary>
        ///  The method <c>DamageArmour</c> should reduce the health of the equipped armour
        ///  item by the amount. If the health of the item is <=0 the item should be removed 
        ///  from the character's inventory
        /// </summary>
        /// <param name="amount"></param>
        public void DamageArmour(int amount)
        {
            //Determine if a piece of armour is equipped
            if (this.equippedArmour_ < 0)
                return;

            //Get the item of armour
            //Check to see if the index points to a piece of armour
            Armour tempArmour = (Armour)this.inventory_[equippedArmour_];
            tempArmour.ArmourHealth = tempArmour.ArmourHealth - amount;
            if (tempArmour.ArmourHealth <=0)
            {
                inventory_.RemoveAt(equippedArmour_);
                equippedArmour_ = -1;
                return;
            }
            this.inventory_[equippedArmour_] = tempArmour;

        }

              
        /// <summary>
        ///  The method <c>DamageWeapon</c> should reduce the health of the equipped weapon
        ///  item by the amount. If the health of the item is <=0 the weapon should be removed 
        ///  from the character's inventory
        /// </summary>
        /// <param name="amount"></param>
        public void DamageWeapon(int amount)
        {
            //Determine if a piece of armour is equipped
            if (this.equippedWeapon_ < 0)
                return;

            //Get the item of armour
            //Check to see if the index points to a piece of armour
            Weapon tempWeapon = (Weapon)this.inventory_[equippedWeapon_];
            tempWeapon.WeaponHealth = tempWeapon.WeaponHealth - amount;
            if (tempWeapon.WeaponHealth <= 0)
            {
                inventory_.RemoveAt(equippedWeapon_);
                equippedWeapon_ = -1;
                return;
            }
            this.inventory_[equippedWeapon_] = tempWeapon;

        }

    } //End gamecharacter class






}
