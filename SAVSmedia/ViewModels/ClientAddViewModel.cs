using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAVSmedia.ViewModels
{
    public class ClientAddViewModel
    {
            public string name { get; set; }

            public string companyName { get; set; }

            public string emailId { get; set; }

            public int contactNumber { get; set; }

            public ClientAddViewModel(string name, string companyName, string emailId, int contactNumber)
            {
                this.name = name;
                this.companyName = companyName;
                this.emailId = emailId;
                this.contactNumber = contactNumber;
            }

        public ClientAddViewModel()
        { }
        }
}
