using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Main.users
{
    class Buyer : IUser
    {
        // MARK:- PROPERTIES
        private Object productLock = new object();
        public int id { get; set; }
        public string name { get; set; }
        public int BidLimit { get; set; }
        public bool LimitReached = false;
 
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
            
            lock (productLock)
            {
                    //!_item.IsMyBidLast(this.name) && !BidLimitReached(_item)
                    while (!_item.IsMyBidLast(name) && !BidLimitReached(_item))
                    {

                        // Check price of item
                        if (_item.GetBidPrice() == 0)
                        {
                            // if no bid has been made, make Ask price your bid
                            _item.AddBid(CreateBid(_item.GetAskPrice() + (BidLimit + 33)));
                            _item.SetNameOfLastBidder(name);
                            Console.WriteLine("{0} added bid of {2} to {1}", name, _item.GetProductName(), _item.GetBidPrice());

                        }
                        else
                        {
                            // if bid exist, make highest bid + your new bid
                            _item.AddBid(CreateBid(_item.GetBidPrice() + 1));
                            _item.SetNameOfLastBidder(name);
                            Console.WriteLine("{0} added bid of {2} to {1}", name, _item.GetProductName(), _item.GetBidPrice());

                        }
                    }
            }

            // Check If My Name If Last
            
        }
        

        public bool BidLimitReached(Product _item)
        {
            // Check if GetBidPrice is > my limit
            if (_item.GetBidPrice() > _item.GetAskPrice() * BidLimit)
            {
                Console.WriteLine("{0} Limit Reached: true", name);
                LimitReached = true;
                Console.WriteLine("Curren bid price: " + _item.GetBidPrice());
                return true;
            } else
            {
                
                return false;
            }

            // if true: Return "Beyond my limit
        }

        // Create Bid
        public Bid CreateBid(int bidPrice)
        {
            int _bidId = this.id + (BidCount + 1);
            BidCount++;
            return new Bid(_bidId, bidPrice, this.name);
        }

        override
        public string ToString()
        {
            return "name: " + name + "bid count: " + BidCount;
        }
    }
}
