using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP_Vues_Controller.Models;

namespace TP_Vues_Controller.Controllers
{
    public class ClientsController : Controller
    {
        private List<IClients>GenererClients()
        {
            List<IClients> clients = new List<IClients>();
            clients.Add(new IClients() { Id = 1, Nom = "James", Couriel="james@courriel.ca",NoTelephone="514-256-7854"});
            clients.Add(new IClients() { Id = 2, Nom = "Maria", Couriel = "maria@courriel.ca", NoTelephone = "450-785-4521" });
            clients.Add(new IClients() { Id = 3, Nom = "Saul", Couriel = "saul@courriel.ca", NoTelephone = "450-895-6324" });
            clients.Add(new IClients() { Id = 4, Nom = "Jl", Couriel = "jl@courriel.ca", NoTelephone = "450-895-6324" });
            clients.Add(new IClients() { Id = 5, Nom = "Emmanuel", Couriel = "emmanuel@courriel.ca", NoTelephone = "450-845-6324" });
            clients.Add(new IClients() { Id = 6, Nom = "Zarah", Couriel = "zarah@courriel.ca", NoTelephone = "450-855-6324" });
            clients.Add(new IClients() { Id = 7, Nom = "Kary", Couriel = "kary@courriel.ca", NoTelephone = "450-835-6324" });
            clients.Add(new IClients() { Id = 8, Nom = "Jade", Couriel = "jade@courriel.ca", NoTelephone = "450-795-6324" });
            clients.Add(new IClients() { Id = 9, Nom = "Manou", Couriel = "manou@courriel.ca", NoTelephone = "450-899-6324" });
            clients.Add(new IClients() { Id = 10, Nom = "Ammiel", Couriel = "kevin@courriel.ca", NoTelephone = "450-995-6324" });
            

            return clients;
        }
   
        [HttpGet]
        [Route("/Clients")]
        [Route("home/Clients")]
      
        public IActionResult Index()
        {

            List<IClients> clients = GenererClients();

            return View(clients);
            }
        }
    }

