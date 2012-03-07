﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssexBooking.Models;

namespace EssexBooking.Controllers
{
    public class HomeController : Controller
    {
        public ASPNETDBEntities entities = new ASPNETDBEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.cart = new Cart();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Hotels()
        {
            ViewBag.cart = new Cart();
            return View(entities.Hotels);
        }

        public ActionResult Travel()
        {
            return View(entities.TravelTypes);
        }
        public ActionResult Extras()
        {
            ViewBag.cart = new Cart();
            //Booking booking = entities.Bookings.FirstOrDefault(x => x.id == booking_id);
            Booking booking = entities.Bookings.FirstOrDefault();
            return View(booking);
        }

    }
}
