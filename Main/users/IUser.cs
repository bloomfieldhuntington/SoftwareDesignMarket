using System;
using System.Collections.Generic;
using System.Text;

namespace Main.users
{
    interface IUser
    {
        int id { get; set; }
        string name { get; set; }

        int GetUserId();
        string GetUserName();

        void ToString();
    }
}
