using System;
using System.Collections.Generic;
using System.Text;

namespace Main.interfaces
{
    interface IProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int AskPrice { get; set; }
        public int BidPrice { get; set; }
        public List<T> Bids { get; set; }

        public void AddBid(T bid) { }
    }
}
