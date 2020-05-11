using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab13
{
   public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intellegence { get; set; }

        public string Play()
        {
            return $"Name: {Name} Strength: {Strength}  Intellegence: {Intellegence}";
        }
    }
}
