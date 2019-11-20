using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Bid
    {
        int BidId { get { return BidId; } set { this.BidId = value; } }
        int BidPrice { get { return this.BidPrice; } set { this.BidPrice = value; } }
        string BidOwner { get { return this.BidOwner; } set { this.BidOwner = value; } }

        public Bid(int bidId, int bidPrice, string bidOwner)
        {
            this.BidId = bidId;
            this.BidPrice = bidPrice;
            this.BidOwner = bidOwner;
        }
        // MARK:- METHODS

        public int getBidId() { return this.BidId; }
        public int getBidPrice() { return this.BidPrice; }
        public string getBidOwner() { return this.BidOwner; }

        public void setBidId(int _value) { this.BidId = _value; }
        public void setBidPrice(int _value) { this.BidPrice = _value; }
        public void setBidOwner(string _value) { this.BidOwner = _value; }
        

        public string ToString()
        {
            string _nl = "\n";

            return "Bid: " + BidId + _nl + "Price: $ " + BidPrice + _nl + "Made by: " + BidOwner;
        }
    }
}
