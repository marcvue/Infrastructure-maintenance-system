using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_maintenance_system.Services
{
    public class RoutingService : IRoutingService
    {
        public IEnumerable<Server> GetServers()
        {
            List<Server> servers = new List<Server>();

            return servers;
        }

    }
}
