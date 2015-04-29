using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Model
{
    public class UserInfo
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userGroup;

        public string UserGroup
        {
            get { return userGroup; }
            set { userGroup = value; }
        }    
    }
}
