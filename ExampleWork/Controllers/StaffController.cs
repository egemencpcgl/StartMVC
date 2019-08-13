using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWork.Controllers
{
    public class StaffController : Controller
    {
        public static List<Staff> staffs;
        public IActionResult Index()
        {
            List<Staff> staffModels = Staff.GetStaffData();
            if (staffs != null && staffs.Any())
            {
                staffModels.AddRange(staffs);
            }
            return View(staffModels);
        }
        public IActionResult Detail(int id)
        {
            List<Staff> staffModels = Staff.GetStaffData();
            if (staffs != null && staffs.Any())
            {
                staffModels.AddRange(staffs);
            }
            Staff item = staffModels.Where(x => x.Id == id).FirstOrDefault();
            return View(item);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Staff model)
        {
            if (ModelState.IsValid)
            {
                if (staffs == null)
                {
                    staffs = new List<Staff>();
                }
                staffs.Add(model);
                return RedirectToAction("Detail", new { id = model.Id });
            }
            return View(model);
        }
    }
}