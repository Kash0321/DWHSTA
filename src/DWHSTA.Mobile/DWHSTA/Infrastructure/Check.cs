using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Infrastructure
{
    public static class Check
    {
        public static void IsNull(string target, string name)
        {
            if (string.IsNullOrWhiteSpace(target))
                throw new ArgumentNullException(target, name);
        }
    }
}
