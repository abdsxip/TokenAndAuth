using BLL;
//using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenAndAuth.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        private readonly CustomersBLL _customer;
        public CustomerController(CustomersBLL customer)
        {
            _customer = customer;
        }

        public ActionResult Index()
        {
            //List<Customers> customers = _customer.CustomersList();
            // return View(customers);
            return View();
        }
    }
}