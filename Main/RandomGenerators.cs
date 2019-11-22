using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class RandomGenerators
    {
        public class RandomWatchGen
        {
            public int[] WatchPriceAlternatives = { 552, 2500, 7699, 3500, 9999, 8250, 75000, 6250, 799, 15000, 13200 };

            public string[] WatchNameAlternatives = { "Rolex", "Omega", "Breitling", "Nixon", "Casio", "Police", "Seiko", "TAG", "Triwa", "Breguet", "Blancpain", "Hublot" };

            public string RandomWatchProductName()
            {
                Random random = new Random();

                int RandomEPNIndex = random.Next(WatchNameAlternatives.Length);

                return WatchNameAlternatives[RandomEPNIndex];
            }

            public int RandomWatchProductPrice()
            {
                Random random = new Random();

                int RandomEPPIndex = random.Next(WatchPriceAlternatives.Length);

                return WatchPriceAlternatives[RandomEPPIndex];
            }
        }
        public class RandomSellerGen
        {
            public string[] SellerNameAlternatives = { "Pelle Politi", "Prelle Prostata", "Snelle Snasen", "Kællæ Kølla" };

            public string RandomSellerName()
            {
                Random random = new Random();

                int RandomSNIndex = random.Next(SellerNameAlternatives.Length);

                return SellerNameAlternatives[RandomSNIndex];
            }

        }
        public class RandomBuyerGen
        {
            public string[] BuyerNameAlternatives = { "Kjell", "Pål", "Per", "Pelle", "Are", "Lise", "Kari", "Eva", "Espen", "Kåre", "Christian", "Katrine", "Oda", "Knut",
"Jens", "Kristoffer", "Ben", "Jens", "Tore", "Åge", "Ole", "Olav", "Ali", "Mohammed", "John", "Petrine", "Linn", "Jesper" };

            public string RandomBuyerName()
            {
                Random random = new Random();

                int RandomBNIndex = random.Next(BuyerNameAlternatives.Length);

                return BuyerNameAlternatives[RandomBNIndex];
            }
        }

        public class RandomNumberGen
        {
            
            public int RandomNum()
            {
                Random random = new Random();
                int RandomIndex = random.Next(1, 3);
                return RandomIndex;
            }
        }

    }
}
