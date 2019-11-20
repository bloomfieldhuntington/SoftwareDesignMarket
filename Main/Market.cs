using System;
using System.Collections.Generic;
using System.Text;
using Main.users;

namespace Main
{
    class Market
    {
        // State
        List<Object> AllProducts = new List<Object>();
        List<Buyer> AllBuyers = new List<Buyer>();

        // MARK:- METHODS
        
        // AskPrice Buyers to bid
        public void OfferProductToBuyer(Product item, Buyer buyer)
        {
            int _count = 0;
            foreach(Buyer element in AllBuyers)
            {
                Console.WriteLine("OfferProductToBuyer says: The count is " + _count);
                _count++;
            }
        }

        // Take 1 product and offer to buyers

        // MARK:- LOOP
        public void MarketLoop()
        {
            int _n = 0;
            while (_n < 1)
            {
                // Start Market here
                Console.WriteLine("Market Started");

                
                //Ask All buyers ifthey want to bid
                
                 

                _n++;
            }
        }

    }
}
