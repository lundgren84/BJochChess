using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Dealer dealer = new Dealer(1000);
            dealer.GetDeck(deck);
        }
    }
}
