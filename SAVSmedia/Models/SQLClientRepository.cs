using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAVSmedia.Models
{
    public class SQLClientRepository : IClientRepository
    {
        private AppDbContext context;

        public SQLClientRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Clients addClient(Clients client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
            return client;      
        }
    }
}
