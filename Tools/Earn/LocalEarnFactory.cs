using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class LocalEarnFactory : EarnFactory
    {
        private decimal _porcentage;

        public LocalEarnFactory(decimal porcentage)
        {
            _porcentage = porcentage;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(_porcentage);
        }
    }
}
