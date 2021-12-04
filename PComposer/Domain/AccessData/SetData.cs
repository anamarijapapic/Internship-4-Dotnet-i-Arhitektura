using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AccessData
{
    public class SetData
    {
        public static void LoginUser(string name, string surname, string address)
        {
            Domain.CurrentUser = new(name, surname, address);
        }
    }
}
