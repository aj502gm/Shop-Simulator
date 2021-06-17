using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimAndresKarl
{
    public class user
    {
        public int userID;
        public string name;
        public string password;
        public int orderID;

        public user()
        {
            this.userID = 0;
            this.name = "";
            this.password = "";
            this.orderID = 0;
        }
        public user(int userID, string name, string password, int orderID)
        {
            this.userID = userID;
            this.name = name;
            this.password = password;
            this.orderID = orderID;
        }
    }
}
