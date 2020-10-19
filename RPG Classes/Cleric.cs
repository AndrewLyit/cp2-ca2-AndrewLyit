// Shane
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Cleric : GameCharacter
    {

        //Private fields
        private int pietyLevel_; //Must be in range [1..100]
        
        public int PietyLevel
        {
            get { return pietyLevel_; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be > 0");

                pietyLevel_ = value;
            }
        }


        //Constructors

        public Cleric()
        {
            pietyLevel_ = 20;
            
        }

        public Cleric(string name, int exp, int health, int food, double weightLimit, CharacterState state, int piety) : base(name, exp, health, food, weightLimit, state)
        {
            if (piety < 1)
                throw new ArgumentOutOfRangeException(
                    $"Piety level must be > 0");
            pietyLevel_ = piety;

        }


        public bool Attack(GameCharacter character)
        {
            Console.WriteLine($"The cleric {CharacterName} is attacking {character.CharacterName}");
            return true;
        }
    }
}
