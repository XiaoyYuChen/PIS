using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Model;

namespace BLL
{
    public  class UserHelper
    {
        public static UserInfo user;
         static UserHelper()
        {
            user = new UserInfo() { UserName = "admin",UserId=1 };
        }
    }
}
