using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class RandomInteger
    {
        protected Random random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
        protected int currentRandomNumber = 0;

        public RandomInteger()
        {

        }

        public virtual int GenerateRandomNumber()
        {
            currentRandomNumber = random.Next();
            return currentRandomNumber;
        }

        public int GetCurrentRandomNumber() { return currentRandomNumber; }
    }
}
