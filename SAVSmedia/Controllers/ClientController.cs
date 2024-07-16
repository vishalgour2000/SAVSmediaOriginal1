using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SAVSmedia.Models;
using SAVSmedia.ViewModels;

namespace SAVSmedia.Controllers
{
    public class ClientController : Controller
    {

        public IClientRepository clients;

        public ClientController(IClientRepository clients)
        {
            this.clients = clients;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientAddViewModel client)
        {
            if (ModelState.IsValid)
            {
                Clients c = new Clients
                {
                    name = client.name,
                    companyName = client.companyName,
                    emailId = client.emailId,
                    contactNumber = client.contactNumber
                };
                clients.addClient(c);
            }
            return RedirectToAction("index");
        }


    }
}
