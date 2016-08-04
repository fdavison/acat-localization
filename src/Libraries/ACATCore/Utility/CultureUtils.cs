using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace ACAT.Lib.Core.Utility
{
    public class CultureUtils
    {
        public static bool SetCulture(string cultureName)
        {
            bool retVal = false;
            try
            {
                Log.Info("setting culture to: " + cultureName);
                CultureInfo newCulture = new CultureInfo(cultureName);
                
                Thread.CurrentThread.CurrentCulture = newCulture;
                Thread.CurrentThread.CurrentUICulture = newCulture;
                CultureInfo.DefaultThreadCurrentCulture = newCulture;
                CultureInfo.DefaultThreadCurrentUICulture = newCulture;

                retVal = true;
            }
            catch (Exception ex)
            {
                Log.Error("Failed to set culture", ex);
            }
            return retVal;
        }
    }
}
