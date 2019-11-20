using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    class Seller : IUser
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

        void IUser.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
