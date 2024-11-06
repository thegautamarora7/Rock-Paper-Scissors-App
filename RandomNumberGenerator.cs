using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    // This class is responsible for generating the computer's choice in the Rock-Paper-Scissors game
    public class RandomNumberGenerator
    {
        // Method to generate a random choice for the computer (1 for Rock, 2 for Paper, 3 for Scissors)
        public int generateComputerChoice()
        {
            // Create a new Random object to generate random numbers
            Random rand = new Random();

            // Generate a random number between 1 and 3 (inclusive) to represent Rock, Paper, or Scissors
            int compChoice = rand.Next(1, 4);

            // Return the generated computer choice
            return compChoice;
        }

    }
}
