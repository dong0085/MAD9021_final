using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class RangedRandomInteger : RandomInteger
    {
        protected int maximum;
        protected int minimum;

        public RangedRandomInteger()
        {

        }

        public RangedRandomInteger(int minimum, int maximum)
        {
            SetMaximum(maximum);
            SetMinimum(minimum);
        }

        // Setters

        public void SetMaximum(int maximum)
        {
            if (maximum == 20 || maximum == 100 || maximum == 1000)
            {
                this.maximum = maximum;
            }
        }
        public void SetMinimum(int minimum)
        {
            if (minimum == 1 || minimum == 10 || minimum == 100)
            {
                this.minimum = minimum;
            }
        }

        // Getters
        public int getMinimum()
        {
            return this.minimum;
        }
        public int getMaximum()
        {
            return this.maximum;
        }

        public override int GenerateRandomNumber()
        {
            int randomNum = random.Next(minimum, maximum);
            return randomNum;
        }

    }
}
