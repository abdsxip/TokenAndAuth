using BLL;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenAndAuth.Controllers
{
    public class CustomersController : Controller
    {

        private readonly CustomersBLL _addCustomer;

        public CustomersController() : this(new CustomersBLL())
        {
             //
        }

        public CustomersController(CustomersBLL customer)
        {
            this._addCustomer = customer;
        }
        // GET: Customers

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadData()
        {

            try
            {
                var draw = Request.Form.GetValues("draw").FirstOrDefault();
                var start = Request.Form.GetValues("start").FirstOrDefault();
                var length = Request.Form.GetValues("length").FirstOrDefault();
                var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
                var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();


                //Paging Size (10,20,50,100)    
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data    
                var customerData = _addCustomer.CustomersList();


                ////Sorting    
                //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                //{
                //    customerData = customerData.OrderBy(sortColumn + " " + sortColumnDir);
                //}
                //Search    
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.CompanyName.ToLower().Contains(searchValue.ToLower())).ToList();
                }

                //total number of rows count     
                recordsTotal = customerData.Count();
                //Paging     
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                //var data = customerData;
                //Returning Json Data    
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data },JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                throw;
            }
            // return View(_addCustomer.CustomersList());
        }

        public ActionResult DataTable()
        {
            List<Customers> result = _addCustomer.CustomersList();
            return View(result);
        }
    }
}