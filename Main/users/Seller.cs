using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    class Seller : IUser
    {
        public int id { get; set; }
        public string name { get; set; }

        public Seller(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }
        public int GetUserId()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        override
        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
