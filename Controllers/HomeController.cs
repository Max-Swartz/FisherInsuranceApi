﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FisherInsuranceApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("This is the index of the HomeController");
        }
    }
}
