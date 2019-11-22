using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    class Seller : IUser
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
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
