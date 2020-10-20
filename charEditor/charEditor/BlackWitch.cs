using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class BlackWitch : GameCharacter
    {
        //Private fields
        private int magicProficiency_; //Must be in range [1..100]
        private int darkPower_; //Must be in range [1..100]

        //Properties
        public int MagicProficiency
        {
            get { return magicProficiency_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"The Magic proficiency must be > 0");

                magicProficiency_ = value;
            }
        }

        public int DarkPower
        {
            get { return darkPower_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"The dark power must be > 0");

                darkPower_ = value;
            }
        }

        //Constructors
        public BlackWitch()
        {
            magicProficiency_ = 60;
            darkPower_ = 50;
        }

        public BlackWitch(string name, int exp, int health, int food, double weightLimit, CharacterState state, int magicProf, int darkPower) : base(name, exp, health, food, weightLimit, state)
        {
            if (magicProf < 1)
                throw new ArgumentOutOfRangeException(
                    $"Magic proficiency must be > 0");
            magicProficiency_ = magicProf;

            if (darkPower < 1)
                throw new ArgumentOutOfRangeException(
                    $"Dark power must be > 0");
            darkPower_ = darkPower;

        }


        public bool Attack(GameCharacter character)
        {
            Console.WriteLine($"The blackwitch {CharacterName} is attacking {character.CharacterName}");
            return true;
        }

    }
}
