using System;
using System.Collections.Generic;
using System.Text;
using Main.interfaces;

namespace Main
{
    public class Product
    {
        // MARK:- PROPERTIES
        //private Object productLock = new object();
        int Id;
        string ProductName;
        int AskPrice;
        int BidPrice;
        int SellerId;
        string NameOfLastBidder;
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
        public string GetLastNameOfBidder() { return this.NameOfLastBidder; }
        public void SetProductId(int _value) { this.Id = _value; }
        public void SetProductName(string _value) { this.ProductName = _value; }
        public void SetAskPrice(int _value) { this.AskPrice = _value; }
        public void SetBidPrice(int _value) { this.BidPrice = _value; }
        public void SetSellerId(int _value) { this.SellerId = _value; }
        public void SetNameOfLastBidder(string _name) { this.NameOfLastBidder = _name; }

        // MARK:- METHODS

        // Add "Bid" to "Bids"
        internal void AddBid(Bid bid)
        {
            //Console.WriteLine("{0} is adding a bid to {1}", bid.getBidOwner(), ProductName);
            
                if (BidPrice <= 0)
                {

                    SetBidPrice(bid.getBidPrice());

                    Bids.Add(bid);
                    // Console.WriteLine("{2}: {0} current bid: {1}", ProductName, bid.getBidPrice(), bid.getBidOwner());

                }
                else
                {
                    SetBidPrice(bid.getBidPrice());
                    Bids.Add(bid);
                    //Console.WriteLine("{2}: {0} current bid: {1}", ProductName, bid.getBidPrice(), bid.getBidOwner());
                }
            }
        

        public bool IsMyBidLast(string _name)
        {
            if (NameOfLastBidder == _name)
            {
                return true;
            }

            return false;

        }


        public bool IsBidsListEmpty()
        {
            if (Bids.Count == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

       

        override
        public string ToString()
        {
            string nl = "\n";
            return nl + " id: " + this.Id + nl + " ProductName: " + this.ProductName + nl + " Initial ask Price: $" + this.AskPrice + nl + " Last bid price: $" + this.BidPrice + nl + " Seller id: " + this.SellerId + nl + " Number of bids: " + this.Bids.Count + nl + " Final bidder and winner: " + this.NameOfLastBidder + nl;
        }
    }
}
