﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessTheNumberGame newGame = new GuessTheNumberGame();
            newGame.start();
        }
    }
}
