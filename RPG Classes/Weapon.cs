/*
* Weapon.cs
*
* Version information v0.1
* Author: Dr. Shane Wilson
* Date: 05/02/2020
* Description: Weapon class for weapons that characters may have
* Copyright notice
*/

/// <summary> Class <c> Weapon </c> implements a weapon object for RGP game characters
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
   public class Weapon : Item
    {
        //Weapon class Fields
        private int weaponHitStrength_;//The damage the weapon does. Must be in range [1..100]
        private int weaponHealth_; //The health of the weapon. Must be in range [1..100]

        //Weapon class Properties
        public string WeaponName
        {
            get { return base.ItemName; }
            set
            {
                if (value.Length >= 0)
                    base.ItemName= value;

                if (value.Length == 0) 
                {
                    throw new ArgumentException("Weapon name cannon be null");
                }

            }
        }

        public double WeaponWeight
        {
            get { return base.ItemWeight; }
            set
            {
                if (value >= 0)
                    base.ItemWeight = value;

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weapon weight cannot be <=0");
                }
            }
        }

        public double WeaponValue
        {
            get { return base.ItemValue; }
            set
            {
                if (value >= 0)
                    base.ItemValue = value;

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Weapon value cannot be <0");
                }
            }
        }

        public int WeaponHitStrength
        {
            get { return weaponHitStrength_; }
            set
            {
                if (value >= 1)
                    weaponHitStrength_ = value;

                if (value <1)
                {
                    throw new ArgumentOutOfRangeException("Weapon hit strength cannot be <0");
                }
            }
        }

        public int WeaponHealth
        {
            get { return weaponHealth_; }
            set
            {
                if (value >= 1)
                    weaponHealth_ = value;
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weapon health cannot be <=0");
                }
            }
        }

        //Weapons class Methods
        /// <summary>
        /// The default constructor for <c>Weapon</c> should create an weapon object
        /// with the following default values:
        /// WeaponName = "Spoon";
        /// WeaponValue = 0.5;
        /// WeaponWeight = 0.1;
        /// WeaponHitStrength = 1;
        /// WeaponHealth = 100;
        /// </summary>
        public Weapon()
        {
            WeaponName = "Spoon";
            WeaponValue = 0.5;
            WeaponWeight = 0.1;
            WeaponHitStrength = 1;
            WeaponHealth = 100;
        }

        public Weapon(string name, double value, double weight, int hitStrength, int health)
        {
            WeaponName = name;
            WeaponValue = value;
            WeaponWeight = weight;
            WeaponHitStrength = hitStrength;
            WeaponHealth = health;
        }

    }
}
