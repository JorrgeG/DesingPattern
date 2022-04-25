using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class LocalEarn : IEarn
    {
        private decimal _porcentage;

        public LocalEarn(decimal porcentage)
        {
            _porcentage = porcentage;
        }
        public decimal Earn(decimal amount)
        {
            return amount * _porcentage;
        }
    }
}
