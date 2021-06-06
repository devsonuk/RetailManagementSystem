using System;
using System.Configuration;

namespace RMSDesktopUILibrary.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        public double GetTaxRate()
        {
            var rateText = ConfigurationManager.AppSettings["taxRate"];

            var isValid = Double.TryParse(rateText, out double result);
            if (!isValid)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly");
            }
            return result;
        }
    }
}
