using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Brawler : GameCharacter
    {
        //Private fields
        private int punchDamage_; //Must be in range [1..100]
        private int strength_; //Must be in range [1..100]


        public int PunchDamage
        {
            get { return punchDamage_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be > 0");

                punchDamage_ = value;
            }
        }

        public int Strength
        {
            get { return strength_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be > 0");

                strength_ = value;
            }
        }

        public Brawler()
        {
            punchDamage_ = 20;
            strength_ = 30;
        }

        public Brawler(string name, int exp, int health, int food, double weightLimit, CharacterState state, int punchDamage, int strength) : base (name, exp, health, food, weightLimit, state)
        {
            if (punchDamage < 1)
                throw new ArgumentOutOfRangeException(
                    $"punchDamage damage must be > 0");
            punchDamage_ = punchDamage;

            if (strength < 1)
                throw new ArgumentOutOfRangeException(
                    $"punchDamage damage must be > 0");
            strength_ = strength;
        }



        public override bool Attack(GameCharacter character)
        {
            Console.WriteLine($"The brawler {CharacterName} is attacking {character.CharacterName}");
            return true;
        }
    }
}
