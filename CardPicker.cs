using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomValue()
        {   // Get a random number from 1 to 13
            int value = random.Next(1, 14);
            // If value is 1, return Ace
            if (value == 1) return "Ace";
            // If value is 11, return Jack
            if (value == 11) return "Jack";
            // If value is 12, return Queen
            if (value == 12) return "Queen";
            // If value is 13, return King
            if (value == 13) return "King";
            // If we haven't returned yet, return value as a string
            return value.ToString();
        }

        private static string RandomSuit()
        {   // Get a random number from 1 to 4
            int value = random.Next(1, 5);
            // If value is 1, return Spades
            if (value == 1) return "Spades";
            // If value is 2, return Hearts
            if (value == 2) return "Hearts";
            // If value is 3, return Clubs
            if (value == 3) return "Clubs";
            // If we haven't returned yet return Diamonds
            return "Diamonds";
        }
    }  
}
