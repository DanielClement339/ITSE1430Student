using EventPlanner.Mvc.App_Start;
using EventPlanner.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventPlanner.Mvc.Controllers
{
    public class EventController : Controller
    {
        public EventController()
        {
            
        }

        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult My()
        {
            EventCriteria eventCriteria = default(EventCriteria);
            eventCriteria.IncludePublic = true;
            eventCriteria.IncludePrivate = true;

            var events = DatabaseFactory._database.GetAll(eventCriteria);

            return View(events.Select(i => new EventModel(i)));
        }

        [HttpGet]
        public ActionResult PublicEvents()
        {
            EventCriteria eventCriteria = default(EventCriteria);
            eventCriteria.IncludePublic = true;
            eventCriteria.IncludePrivate = false;

            var events = DatabaseFactory._database.GetAll(eventCriteria);

            return View(events.Select(i => new EventModel(i)));
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var Event = DatabaseFactory._database.Get(id);

            return View(new EventModel(Event));
        }

        [HttpGet]
        public ActionResult Create()
        {
            EventModel eventModel = new EventModel();
            var model = eventModel;
            model.StartDate = DateTime.Now;
            model.EndDate = DateTime.Now;
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EventModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var Event = model.ToDomain();
                    if (model.Name == null || model.Name == "")
                        return HttpNotFound();

                    DatabaseFactory._database.Add(Event);
                    if (Event.IsPublic)
                        return RedirectToAction("Public");
                    else
                        return RedirectToAction("My");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Event = DatabaseFactory._database.Get(id);

            return View(new EventModel(Event));
        }

        [HttpPost]
        public ActionResult Edit(EventModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var Event = model.ToDomain();
                    if (Event == null)
                        return HttpNotFound();

                    DatabaseFactory._database.Update(Event.Id, Event);
                    if (Event.IsPublic)
                        return RedirectToAction("Public");
                    else
                        return RedirectToAction("My");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = DatabaseFactory._database.Get(id);

            return View(new EventModel(item));
        }

        [HttpPost]
        public ActionResult Delete(EventModel model)
        {
            try
            {
                var Event = DatabaseFactory._database.Get(model.Id);

                if (Event == null)
                    return HttpNotFound();

                DatabaseFactory._database.Remove(Event.Id);

                if (model.IsPublic)
                    return RedirectToAction("Public");
                else
                    return RedirectToAction("My");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(model);
            };
        }

        private readonly IEventDatabase _eventDatabase;
    }
}