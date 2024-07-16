using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAVSmedia.Models
{
   
    public class Clients
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string companyName { get; set; }

        public string emailId { get; set; }

        public int contactNumber { get; set; }

        public Clients(int Id,string name, string companyName, string emailId, int contactNumber)
        {
            this.Id = Id;
            this.name = name;
            this.companyName = companyName;
            this.emailId = emailId;
            this.contactNumber = contactNumber;
        }

        public Clients()
        { }
    }
}
