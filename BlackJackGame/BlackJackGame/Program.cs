using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool isPlaying = true;
            bool isStanding = false;
            bool dealerBusted = false;
            bool playerBusted = false;
            int playerHandTotal;
            int dealerTotal;

            Console.Title = "--&& BlackJack &&--";
            Console.WriteLine("Welcome to the BlackJack table!\n" +
                "Please enter your name or type \"exit\" to quit");

            string userName = Console.ReadLine();

            if (userName.ToLower() == "exit")
            {
                isPlaying = false;
            }
            Deck playDeck = new Deck();
           while (isPlaying)
            {
                if (playDeck.Count() < 10)
                {
                    playDeck = new Deck();
                }

                dealerTotal = 0;
                

                Console.Clear();
                List<Cards> playerHand = new List<Cards>();
                List<Cards> computerHand = new List<Cards>();
                isPlaying = true;
                isStanding = false;
                playerBusted = false;

                for (int i = 0; i < 2 ; i++)
                {
                    playerHand.Add(playDeck.Deal());
                    computerHand.Add(playDeck.Deal());
                }

                do
                {
                    playerHandTotal = 0;
                    Console.Clear();
                    Console.WriteLine($"Dealers Hand: {computerHand[1].Name}\n\n\n");
                    Console.Write("Player Hand: ");
                    foreach (var card in playerHand)
                    {
                        Console.Write(card.Name + " ");
                        playerHandTotal += card.FaceValue;
                    }
                    Console.WriteLine($"\n\nYour Total: {playerHandTotal}");
                    System.Threading.Thread.Sleep(2000);

                    if (playerHandTotal > 21)
                    {
                        Console.Clear();
                        Console.WriteLine("You Bust! Better luck next time");
                        System.Threading.Thread.Sleep(3000);
                        isStanding = true;
                        playerBusted = true;
                    }

                    if (!playerBusted)
                    {
                        Console.WriteLine("\nWould you like to:" +
                       "\n1) Hit" +
                       "\n2) Stand");
                        string userInput = Console.ReadLine().ToUpper();
                        switch (userInput)
                        {
                            case "1":
                            case "H":
                            case "HIT":
                                playerHand.Add(playDeck.Deal());
                                break;
                            case "2":
                            case "S":
                            case "STAND":
                                isStanding = true;
                                break;
                            default:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Input not recognized, please try again. . .");
                                Console.ResetColor();
                                break;
                        }
                    }
                   
                    
                } while (!isStanding);
                Console.Clear ();

                if (!playerBusted)
                {
                    isStanding = false;
                    do
                    {
                        Console.Clear();
                        Console.Write("Dealer's Hand: ");
                        foreach (var card in computerHand)
                        {
                            Console.Write(card.Name + " ");
                            dealerTotal += card.FaceValue;
                        }

                        Console.Write($"\n\nPlayer Hand: ");
                        foreach (var card in playerHand)
                        {
                            Console.Write(card.Name + " ");
                            Console.WriteLine("Your Hand Total: {0}",playerHandTotal);
                        }
                        System.Threading.Thread.Sleep(2000);
                        if (dealerTotal < 17)
                        {
                            computerHand.Add(playDeck.Deal());
                            
                        }
                        else if (dealerTotal >= 17 && dealerTotal <= 21)
                        {
                            Console.WriteLine("The dealer stands at " + dealerTotal);
                            isStanding = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Dealer Busted!");
                            System.Threading.Thread.Sleep(3000);
                            isStanding = true;
                            dealerBusted = true;
                        }
                    } while (!isStanding);
                }

                
                if (playerHandTotal < dealerTotal || playerBusted == true)
                {
                    Console.WriteLine("You Lose!");
                }
                else if (playerHandTotal > dealerTotal || dealerBusted == true)
                {
                    Console.WriteLine("You Won!");
                }
                else if (playerHandTotal == dealerTotal)
                {
                    Console.WriteLine("You tied");
                }

                Console.WriteLine("Would you like to play again? Y/N");
                ConsoleKey playAgain = new ConsoleKey();
                playAgain = Console.ReadKey().Key;
                
                switch (playAgain)
                {
                    case ConsoleKey.N:
                        isPlaying = true;
                        break;
                }


            }
        }
    }
}
