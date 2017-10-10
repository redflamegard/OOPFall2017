using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
       
        static void Main()
        { // Get Players

            GameManager.GameSetup();

        }
    }


    class GameManager
    {
        static public List<string> ShuffledDeck = new List<string>();
        public static List<Player> currentPlayers = new List<Player>();
        public static string UserInput;
        static int numPlayers, userInput, activePlayer;
        
 
        static public void PlayerSetup ()
        {

            Console.WriteLine("How Many Players are going to play");
            Console.ForegroundColor=ConsoleColor.Green;
            UserInput = Console.ReadLine();
            numPlayers = Int32.Parse(UserInput);
            //Add a try catch
            for (int totalPlayers = 0; totalPlayers < numPlayers; totalPlayers++)
            {
                Console.Clear();
                currentPlayers.Add(new Player());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What is your name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                UserInput = Console.ReadLine();
                currentPlayers[totalPlayers].Name = UserInput;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Is this a Human or AI");
                Console.WriteLine("Please Type 1 for Human  or  2  for AI");
                Console.ForegroundColor = ConsoleColor.Green;
                UserInput = Console.ReadLine();
                userInput = Int32.Parse(UserInput);
            // Add a try catch              
               
                switch (userInput)
                {
                    case 1:
                        currentPlayers[totalPlayers].isHumman = true;
                        currentPlayers[totalPlayers].type = "Human";
                        break;
                    case 2: currentPlayers[totalPlayers].isHumman = false;
                        currentPlayers[totalPlayers].type = "AI";
                        break;
                    default: 
                        break;
                }
            }

        }
        static public void GameSetup()
        { // Get Players
#region Create Players
            PlayerSetup();
#endregion
            Console.Clear();
#region GenerateDeck
            Cards GenerateDeck = new Cards();
            GenerateDeck.PrintDeck();
#endregion
            //creates deck
#region Displaying Current Players and their hands
            for (int currPlayers = 0; currPlayers < currentPlayers.Count; currPlayers++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Player: "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(currentPlayers[currPlayers].Name); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nType: " + currentPlayers[currPlayers].type );
                currentPlayers[currPlayers].Draw();



                Console.WriteLine("\n");
            }
#endregion
            Console.ReadLine();
#region Player Turns
            //Determine Active Player
            //Set Active Player True
            //Input only Triggers for Active Player
            //Rotate to the next Player in Line
#endregion


            //Deal Hands



            //Play Game



            //End Game


        }

    }
 
    class Player
    {
        public string Name, type;
        public int Handsize = 0, maxHandSize = 5;
        public string[] hand = { "Card1", "Card2", "Card3", "Card4", "Card5" };
        public bool isHumman;
      

        public void Draw ()
        {         
            for (int handsize = 0; handsize < maxHandSize; handsize++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                hand[handsize] = GameManager.ShuffledDeck[0].ToString();
                GameManager.ShuffledDeck.RemoveAt(0);
                Console.WriteLine(hand[handsize].ToString());

            }         

        }
        void Discard ()
        {


        }
         void Pass ()
        {




        }
    }
    class Cards
    {
        List<string> DeckofCards = new List<string>();
        
        string Suit;
        string Number;
        string[] Suits = { "Diamonds", "Spades", "Hearts", "Clubs" };
        string[] Numbers = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        byte x = 0;
        byte y = 0;
        int RandomCard;
        Random RandomNumber = new Random();


        public void PrintDeck()
        {
            while (x < 4)
            {
                DeckofCards.Add("The " + Numbers[y] + " of " + Suits[x]);
                if (y == 12)
                {
                    x++;
                    y = 0;
                }
                else
                {
                    y++;
                }
            }



            for (int x = GameManager.ShuffledDeck.Count; x < 52; x++)
            {
                RandomCard = RandomNumber.Next(DeckofCards.Count());
                //Console.WriteLine(DeckofCards.Count);
              //  Console.WriteLine(RandomCard.ToString());
                GameManager.ShuffledDeck.Add(DeckofCards[RandomCard]);
                DeckofCards.RemoveAt(RandomCard);

            }
        }

        public void DealCards()
        {
           

        }
    }
}