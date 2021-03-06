﻿using MVCManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCManagement.Controllers
{
    public class ManagementController : Controller
    {
        private ManagementDbContext db = new ManagementDbContext();

        IEnumerable<Employee> employees;
        IEnumerable<Product> products;
        IEnumerable<Supplier> suppliers;
        IEnumerable<Category> categories;

        public ManagementController()
        {
            employees = db.Employees.ToList();
            products = db.Products.ToList();
            suppliers = db.Suppliers.ToList();
            categories = db.Categories.ToList();
        }

        // GET: Managment
        public ActionResult Index()
        {
            return View(employees);
        }

        public ActionResult BuildEmployeeTable()
        {
            return PartialView("_EmployeeData", employees);
        }

        public ActionResult BuildProductTable()
        {
            return PartialView("_ProductData", products);
        }

        public ActionResult BuildSupplierTable()
        {
            return PartialView("_SupplierData", suppliers);
        }

        public ActionResult BuildCategoryTable()
        {
            return PartialView("_CategoryData", categories);
        }

        public PartialViewResult EmployeeData()
        {
            return PartialView(employees);
        }
    }
}