using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAVSmedia.Models
{
    public interface IClientRepository
    {
        Clients addClient(Clients client);
    }
}
