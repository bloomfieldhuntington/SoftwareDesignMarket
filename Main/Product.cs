using System;
using System.Collections.Generic;
using System.Text;
using Main.interfaces;

namespace Main
{
    class Product
    {
        // MARK:- PROPERTIES
        int Id;
        string ProductName;
        int AskPrice;
        int BidPrice;
        int SellerId;
        // Bids
        List<Bid> Bids = new List<Bid>();

        public Product(int id, string productName, int price, int sellerId)
        {
            this.Id = id;
            this.ProductName = productName;
            this.AskPrice = price;
            this.SellerId = sellerId;
        }

        // MARK:- GETTERS & SETTERS
        public int GetProductId() { return this.Id; }
        public string GetProductName() { return this.ProductName; }
        public int GetAskPrice() { return this.AskPrice; }
        public int GetBidPrice() { return this.BidPrice; }
        public int GetSellerId() { return this.SellerId; }
        public void SetProductId(int _value) { this.Id = _value; }
        public void SetProductName(string _value) { this.ProductName = _value; }
        public void SetAskPrice(int _value) { this.AskPrice = _value; }
        public void SetBidPrice(int _value) { this.BidPrice = _value; }
        public void SetSellerId(int _value) { this.SellerId = _value; }

        // MARK:- METHODS

        // Add "Bid" to "Bids"
        public void AddBid(Bid bid)
        {
            if (BidPrice <= 0)
            {
                SetBidPrice(bid.getBidPrice());
                Bids.Add(bid);
                Console.WriteLine(bid.getBidPrice());
            }
            else
            {
                SetBidPrice(bid.getBidPrice());
                Bids.Add(bid);
                Console.WriteLine(bid.getBidPrice());
            }
        }


       

        override
        public string ToString()
        {
            string nl = "\n";
            return nl + "id: " + this.Id + nl + "name: " + this.ProductName + nl + "ask: " + this.AskPrice + nl + "bid: " + this.BidPrice + nl + "seller id: " + this.SellerId + nl + "bids: " + this.Bids.Count + nl;
        }
    }
}
