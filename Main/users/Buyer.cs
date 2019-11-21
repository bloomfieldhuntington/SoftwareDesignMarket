using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    class Buyer : IUser
    {
        // MARK:- PROPERTIES
        public int id { get; set; }
        public string name { get; set; }
        public int BidLimit { get; set; }
        private int BidCount = 0;

        public Buyer(int _id, string _name, int _bidLimit)
        {
            this.id = _id;
            this.name = _name;
            this.BidLimit = _bidLimit;
        }

        // MARK:- GETTERS & SETTERS
        public int GetUserId() { return this.id; }
        public string GetUserName() { return this.name; }
        public void SetUserId(int _value) { this.id = _value; }

        // MARK:- METHODS

        // Primary bid method
        public void Bid(Product _item)
        {
            // Check price of item
            if(_item.GetBidPrice() == 0)
            {
                // if no bid has been made, make Ask price your bid
                _item.AddBid(CreateBid(_item.GetAskPrice() + 1));
                Console.WriteLine("{0} added bid to {1}", name, _item.GetProductName());
            }
            else if (!BidLimitReached(_item))
            {
                // if bid exist, make highest bid + your new bid
                _item.AddBid(CreateBid(_item.GetBidPrice() + 1));
                Console.WriteLine("{0} added bid to {1}", name, _item.GetProductName());
            }
        }

        public bool BidLimitReached(Product _item)
        {
            // Check if GetBidPrice is > my limit
            if (_item.GetBidPrice() > _item.GetAskPrice() * BidLimit)
            {
                Console.WriteLine("{0} Limit Reached: true", name);
                Console.WriteLine(_item.GetBidPrice());
                return true;
            } else
            {
                Console.WriteLine("{0} Limit Reached: false", name);
                return false;
            }

            // if true: Return "Beyond my limit
        }

        // Create Bid
        public Bid CreateBid(int bidPrice)
        {
            int _bidId = this.id + (BidCount + 1);
            return new Bid(_bidId, bidPrice, this.name);
        }

        override
        public string ToString()
        {
            return "name: " + name;
        }
    }
}
