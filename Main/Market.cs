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
        RandomGenerators.RandomWatchGen RanProd = new RandomGenerators.RandomWatchGen();
        RandomGenerators.RandomBuyerGen RanBuy = new RandomGenerators.RandomBuyerGen();
        RandomGenerators.RandomSellerGen RanSel = new RandomGenerators.RandomSellerGen();
        RandomGenerators.RandomNumberGen RanNum = new RandomGenerators.RandomNumberGen();



        // MARK:- METHODS

        // AskPrice Buyers to bid
        public void OfferProductToBuyer(Product item, Buyer buyer)
        {
            int _count = 0;
            foreach (Buyer element in AllBuyers)
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
                Console.WriteLine("\n WELCOME TO THE MARKET PLACE\n");
                Console.WriteLine(" Market Open" + "\n");

                // TEST AREA

                // Create 1 seller, add to list
                Seller anon = new Seller(1, "anon");

                // Create 1 product, add to List
                Product product1 = new Product(1, RanProd.RandomWatchProductName(), RanProd.RandomWatchProductPrice(), 1);
                Product product2 = new Product(2, RanProd.RandomWatchProductName(), RanProd.RandomWatchProductPrice(), 1);
                Product product3 = new Product(3, RanProd.RandomWatchProductName(), RanProd.RandomWatchProductPrice(), 1);
                Product product4 = new Product(4, RanProd.RandomWatchProductName(), RanProd.RandomWatchProductPrice(), 1);

                AllProducts.Add(product1);
                AllProducts.Add(product2);
                AllProducts.Add(product3);
                AllProducts.Add(product4);


                // Create 1 buyer, add to List
                Buyer buyer = new Buyer(1, RanBuy.RandomBuyerName(), RanNum.RandomNum());
                Buyer buyer2 = new Buyer(2, RanBuy.RandomBuyerName(), RanNum.RandomNum());
                Buyer buyer3 = new Buyer(3, RanBuy.RandomBuyerName(), RanNum.RandomNum());

                AllBuyers.Add(buyer);
                AllBuyers.Add(buyer2);
                AllBuyers.Add(buyer3);



                // Thread testing 11:30

                Thread[] threads = new Thread[AllBuyers.Count];
                Thread.CurrentThread.Name = "Main Thread";


                foreach (Product _product in AllProducts)
                {

                    Console.WriteLine("\n THE NEXT ITEM FOR SALE IS:");

                    // Print out Item For Sale
                    Console.WriteLine(_product.ToString());

                    foreach (Buyer _buyer in AllBuyers)
                    {
                        Thread t = new Thread(() => { _buyer.Bid(_product); });
                        t.Name = AllBuyers.IndexOf(_buyer).ToString();
                        threads[AllBuyers.IndexOf(_buyer)] = t;
                        //Console.WriteLine("Here");

                    }

                    foreach (Thread _thread in threads)
                    {
                        //Console.WriteLine("Thread {0} Alive : {1}", _thread.Name, _thread.IsAlive );
                        _thread.Start();
                        //Console.WriteLine("Thread {0} Alive : {1}", _thread.Name, _thread.IsAlive);
                        Thread.Sleep(1000);

                    }
                }



                Console.WriteLine("\n" + " Market Closed" + "\n" + "\n");
                Console.WriteLine("\n HERE IS THE FINAL RESULT:");


                // Add foreach, print out each prod
                foreach (Product product in AllProducts)
                {
                    Console.WriteLine(product.ToString());
                }

                Console.WriteLine(" Click any key to exit");
                Console.ReadLine();

                



                // TEST AREA END


                _n++;
            }

        }



    }
}