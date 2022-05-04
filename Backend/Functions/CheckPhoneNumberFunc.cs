using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Functions
{
    public static class CheckPhoneNumberFunc
    {
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            return !Regex.IsMatch(phoneNumber, ".*[^0-9].*");
        }
    }
}
