using System;
using System.Collections.Generic;
using System.Text;
using Main.users;
using System.Threading;

namespace Main
{
    class Market
    {
        // State
        List<Product> AllProducts = new List<Product>();
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

        public void StartSelling(Buyer _buyer)
        {
            for (int i = 0; i < AllProducts.Count; i++)
            {
                _buyer.Bid(AllProducts[i]);
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
                Console.WriteLine("Market Open" + "\n");

                // TEST AREA

                // Create 1 product, add to List
                Product iPhone = new Product(1, "iPhone", 199, 1);
                //Product Samsung = new Product(2, "Samsung", 99, 2);
                //Product Freezer = new Product(3, "Freezer", 50, 3);
                //Product Car = new Product(4, "Car", 1999, 4);
                //Product Toy = new Product(5, "Toy", 25, 5);
                AllProducts.Add(iPhone);
                //AllProducts.Add(Samsung);
                //AllProducts.Add(Freezer);
                //AllProducts.Add(Car);
                //AllProducts.Add(Toy);
                

                // Create 1 buyer, add to List
                Buyer buyer = new Buyer(1, "John", 2);
                Buyer buyer2 = new Buyer(2, "Tom", 3);

                AllBuyers.Add(buyer);
                AllBuyers.Add(buyer2);



                // Thread testing 11:30
                

                
                //Ask All buyers if they want to bid
                foreach (Buyer _buyer in AllBuyers)
                {
                    Console.WriteLine(_buyer.ToString());
                    foreach (Product _product in AllProducts)
                    {

                        _buyer.Bid(_product);

                        
                    }

                }





                Console.WriteLine("\n" + "Market Closed" + "\n" + "\n");
                

          
                
                // TEST AREA END
                 

                _n++;
            }
        }

    }
}
