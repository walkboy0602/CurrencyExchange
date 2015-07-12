using AutoMapper;
using CurrencyExchange.Entities;
using CurrencyExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace CurrencyExchange.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext db;

        public PostController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Post
        public ActionResult Index()
        {
            var posts = db.Post.Include("User").OrderByDescending(s => s.Id);
            return View(posts);
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.CurrencyList = GetCurrencyList();
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(PostModel model)
        {
            ViewBag.CurrencyList = GetCurrencyList();

            try
            {
                if (ModelState.IsValid)
                {
                    Post post = Mapper.Map<Post>(model);
                    string uid = User.Identity.GetUserId();
                    post.UserId = User.Identity.GetUserId();
                    db.Post.Add(post);
                    db.SaveChanges();
                    //TempData["Message"] = "Thank you. Your request has been received.";
                    return RedirectToAction("Complete");
                }
            }
            catch
            {
                return View(model);
            }

            return View(model);
        }

        public ActionResult Complete()
        {
            return View();
        }

        private List<SelectListItem> GetCurrencyList()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            list.Add(new SelectListItem() { Selected = false, Text = "RM", Value = "RM" });
            list.Add(new SelectListItem() { Selected = false, Text = "USD", Value = "USD" });
            list.Add(new SelectListItem() { Selected = false, Text = "SGD", Value = "SGD" });

            return list;
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
