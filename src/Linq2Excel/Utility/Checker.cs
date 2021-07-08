using System;
using System.Collections.Generic;
using System.Text;

namespace Linq2Excel.Utility
{
    public static class Checker
    {
        public static void NotNull(object obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
