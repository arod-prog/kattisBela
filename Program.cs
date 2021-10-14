using System;
using System.Linq;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reads the first line of input
            String input = Console.ReadLine();
            
            //Splits the input into two variables, strings
            //since we know the input will be 2 characters we split varibales we assign
            String[] HandSuit = input.Split(' ');

            // N is the number of hands (as described in problem description)
            String N = HandSuit[0];
            
            // B is the value of suits (as described in problem description)
            String B = HandSuit[1];
            int H = Int32.Parse(N);

            // Multiples the number of hands by 4, 4 is the number of suits
            String[] cards = new String[4 * H];
            int[] cardValue = new int[4 * H];
            
            // for loops through the numbers of hands
            for (int i = 0; i < H * 4; i++)
            {
                //this reads the card and determines the value
                //each Hand suit carries a numerical value
                //this loops adds that values to 'cardvalue', cards hand, if the suit matches
                cards[i] = Console.ReadLine();
                string str = cards[i];
                char number = str[0];
                if (number == 'A')
                {
                    cardValue[i] = 11;
                }
                if (number == 'K')
                {
                    cardValue[i] = 4;
                }
                if (number == 'Q')
                {
                    cardValue[i] = 3;
                }
                if (number == 'J')
                {
                    //B is the value of suits 
                    if (cards[i].EndsWith(B))
                    {
                        cardValue[i] = 20;
                    }
                    else
                    {
                        cardValue[i] = 2;
                    }
                }
                if (number == 'T')
                {
                    cardValue[i] = 10;
                }
                if (number == '9')
                {
                    if (cards[i].EndsWith(B))
                    {
                        cardValue[i] = 14;
                    }
                    else
                    {
                        cardValue[i] = 0;
                    }
                }

            }
            // Lastly sum the card value of all the hands and print that number
            int sum = cardValue.Sum();
            Console.WriteLine(sum);
        }
    }
}
