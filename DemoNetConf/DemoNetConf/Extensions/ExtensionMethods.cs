using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNetConf.Extensions
{
    public static class ExtensionMethods
    {
        public static string EnumToString(this Enum eff)
        {
            return Enum.GetName(eff.GetType(), eff);
        }
    }
}
