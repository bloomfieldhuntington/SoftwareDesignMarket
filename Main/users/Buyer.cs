using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    class Buyer : IUser
    {
        // MARK:- PROPERTIES
        public int id { get { return this.id; } set { this.id = value; } }
        public string name { get { return this.name; } set { this.name = value; } }
        private int BidCount = 0;

        // MARK:- GETTERS & SETTERS
        public int GetUserId() { return this.id; }
        public string GetUserName() { return this.name; }
        public void SetUserId(int _value) { this.id = _value; }

        // MARK:- METHODS

        // Create Bid
        public Bid CreateBid(int bidPrice)
        {
            int _bidId = this.id + (BidCount + 1);
            return new Bid(_bidId, bidPrice, this.name);
        }

        void IUser.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
