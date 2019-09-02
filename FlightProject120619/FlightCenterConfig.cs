using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject120619
{
    public static class FlightCenterConfig
    {

        public const string ADMIN_NAME = "ADMIN";
        public const string ADMIN_PASSWORD = "9999";
        public const string DAO_CON = @"Data Source=.;Initial Catalog=WorkMyFlights;Integrated Security=True";
        public const int historyTimer = 1000 * 60 * 60 * 24;
    }
}
