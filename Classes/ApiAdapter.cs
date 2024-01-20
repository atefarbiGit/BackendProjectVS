using BackendProjectVS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProjectVS.Classes
{
    public class ApiAdapter : AdapterInterface
    {
        private int balance;

        public ApiAdapter(int balance)
        {
            this.balance = balance;
        }

        public string IsPositive()
        {
            return (balance > 0) ? "true" : "false";
        }
    }

}
