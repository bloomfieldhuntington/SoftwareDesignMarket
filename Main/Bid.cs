using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Bid
    {
        int BidId;
        int BidPrice;
        string BidOwner;

        public Bid(int bidId, int bidPrice, string bidOwner)
        {
            this.BidId = bidId;
            this.BidPrice = bidPrice;
            this.BidOwner = bidOwner;
        }
        // MARK:- GETTERS & SETTERS

        public int getBidId() { return this.BidId; }
        public int getBidPrice() { return this.BidPrice; }
        public string getBidOwner() { return this.BidOwner; }

        public void setBidId(int _value) { this.BidId = _value; }
        public void setBidPrice(int _value) { this.BidPrice = _value; }
        public void setBidOwner(string _value) { this.BidOwner = _value; }
        
        override
        public string ToString()
        {
            string _nl = "\n";

            return "Bid: " + BidId + _nl + "Price: $ " + BidPrice + _nl + "Made by: " + BidOwner;
        }
    }
}
