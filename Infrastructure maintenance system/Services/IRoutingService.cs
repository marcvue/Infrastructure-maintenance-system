using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_maintenance_system.Services
{
    interface IRoutingService
    {
        public IEnumerable<Server> GetServers();
    }
}
