using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    class Buyer : IUser
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetUserId()
        {
            throw new NotImplementedException();
        }

        public void GetUserName()
        {
            throw new NotImplementedException();
        }

        // Create Bid
        public Bid CreateBid(int bidId, int bidPrice, string bidOwner)
        {
            return new Bid(bidId, bidPrice, bidOwner);
        }

        void IUser.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
