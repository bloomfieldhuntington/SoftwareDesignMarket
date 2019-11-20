using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Product
    {
        int Id { get; set; }
        string ProductName { get; set; }
        int AskPrice { get; set; }
        int BidPrice { get; set; }
        int SellerId { get; set; }
        // Bids
        List<Bid> Bids = new List<Bid>();

        public Product(int id, string productName, int price, int sellerId)
        {
            this.Id = id;
            this.ProductName = productName;
            this.AskPrice = price;
            this.SellerId = sellerId;
        }

        // MARK:- METHODS

        // Add "Bid" to "Bids"
        public void AddBid(Bid bid)
        {
            if (BidPrice <= 0)
            {
                SetBidPrice(bid.getBidPrice());
                Bids.Add(bid);
            }
            else { }
        }
        
        // Set "BidPrice" with price of highest bid
        public void SetBidPrice(int _value)
        {
            // Set "BidPrice" equal to _value
        }

        override
        public string ToString()
        {
            return this.ProductName;
        }
    }
}
