using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Deck
    {
        List<Cards> decks = new List<Cards>
        {
            new Cards("Two",2,"Clubs") ,
            new Cards("Three",3,"Clubs"),
            new Cards("Four",4,"Clubs"),
            new Cards("Five",5,"Clubs"),
            new Cards("Six",6,"Clubs"),
            new Cards("Seven",7,"Clubs"),
            new Cards("Eight",8,"Clubs"),
            new Cards("Nine",9,"Clubs"),
            new Cards("Ten",10,"Clubs"),
            new Cards("Jack",10,"Clubs"),
            new Cards("Queen",10,"Clubs"),
            new Cards("King",10,"Clubs"),
            new Cards("Ace",11,"Clubs"),
            ////////////////////////////
            new Cards("Two",2,"Diamonds") ,
            new Cards("Three",3,"Diamonds"),
            new Cards("Four",4,"Diamonds"),
            new Cards("Five",5,"Diamonds"),
            new Cards("Six",6,"Diamonds"),
            new Cards("Seven",7,"Diamonds"),
            new Cards("Eight",8,"Diamonds"),
            new Cards("Nine",9,"Diamonds"),
            new Cards("Ten",10,"Diamonds"),
            new Cards("Jack",10,"Diamonds"),
            new Cards("Queen",10,"Diamonds"),
            new Cards("King",10,"Diamonds"),
            new Cards("Ace",11,"Diamonds"),
            //////////////////////////
            new Cards("Two",2,"Hearts") ,
            new Cards("Three",3,"Hearts"),
            new Cards("Four",4,"Hearts"),
            new Cards("Five",5,"Hearts"),
            new Cards("Six",6,"Hearts"),
            new Cards("Seven",7,"Hearts"),
            new Cards("Eight",8,"Hearts"),
            new Cards("Nine",9,"Hearts"),
            new Cards("Ten",10,"Hearts"),
            new Cards("Jack",10,"Hearts"),
            new Cards("Queen",10,"Hearts"),
            new Cards("King",10,"Hearts"),
            new Cards("Ace",11,"Hearts"),
            //////////////////////////
            new Cards("Two",2,"Spades") ,
            new Cards("Three",3,"Spades"),
            new Cards("Four",4,"Spades"),
            new Cards("Five",5,"Spades"),
            new Cards("Six",6,"Spades"),
            new Cards("Seven",7,"Spades"),
            new Cards("Eight",8,"Spades"),
            new Cards("Nine",9,"Spades"),
            new Cards("Ten",10,"Spades"),
            new Cards("Jack",10,"Spades"),
            new Cards("Queen",10,"Spades"),
            new Cards("King",10,"Spades"),
            new Cards("Ace",11,"Spades"),
        };  
        
        public Deck()
        {

        }

        public Cards Deal()
        {
            Random rand = new Random();
            int cardIndex = rand.Next(51);
            Cards chosenCard = decks[cardIndex];
            decks.Remove(chosenCard);
            return chosenCard;
        }
        
        public int Count()
        {
            return decks.Count();
        }
    }


}
