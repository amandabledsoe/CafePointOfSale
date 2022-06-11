using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePointOfSale
{
    public class UserCart
    {
        public int Id { get; private set; }
        Dictionary<Product,int> UserPicks { get; set; }

        public UserCart()
        {

        }
        public UserCart(int id, Dictionary<Product,int> userPicks)
        {

        }
    }
}
