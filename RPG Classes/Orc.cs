using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Orc : GameCharacter
    {

        //Private fields
        private int ferociousness_; //Must be in range [1..100]
        private int strength_; //Must be in range [1..100]

        //Properties
        public int Ferociousness
        {
            get { return ferociousness_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"The Orc's ferociousness must be > 0");

                ferociousness_ = value;
            }
        }

        public int Strength
        {
            get { return strength_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"The Orc's strength must be > 0");

                strength_ = value;
            }
        }

        //Constructors
        public Orc()
        {
            ferociousness_ = 30;
            strength_ = 80;
        }

        public Orc(string name, int exp, int health, int food, double weightLimit, CharacterState state, int ferociousness, int strength) : base(name, exp, health, food, weightLimit, state)
        {
            if (ferociousness < 1)
                throw new ArgumentOutOfRangeException(
                    $"The Orc's ferociousness must be > 0");
            ferociousness_ = ferociousness;

            if (strength < 1)
                throw new ArgumentOutOfRangeException(
                    $"The Orc's strength must be > 0");
            strength_ = strength;
        }

    }
}
