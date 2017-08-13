using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EncuestasC.Models;

namespace EncuestasC.Controllers
{
    public class GeographicInfoController : Controller
    {

        private EncuestasEntitiesx _entities = new EncuestasEntitiesx();

        #region Provincia

        //Datos para provincia


        //LIST
        public ActionResult GetAllProvinces()
        {
            return View(_entities.Provincia.ToList());

        }

        //CREAR
        public ActionResult CProvincia()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult CProvincia(Provinciax provinciaToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToProvincia(provinciaToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllProvinces");
            }
            catch
            {
                return View();
            }
        }

        //EDITAR
        public ActionResult EditProvince(int id)
        {
            var provinciaToEdit = _entities.Provincia.First(m => m.Id == id);
            return View(provinciaToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditProvince(Provinciax provinciaToEdit)
        {

            // TODO: Add update logic here
            var originalProvincia = _entities.Provincia.First(m => m.Id == provinciaToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalProvincia);

            _entities.ApplyPropertyChanges(originalProvincia.EntityKey.EntitySetName, provinciaToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllProvinces");


        }

        //
        // GET: /Home/Delete/5
        //BORRAR
        public ActionResult DeleteProvince(int id)
        {
            var provinciaToDelete = _entities.Provincia.First(m => m.Id == id);
            return View(provinciaToDelete);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult DeleteProvince(Provinciax provinciaToDelete)
        {
            var originalProvincia = _entities.Provincia.First(m => m.Id == provinciaToDelete.Id);

            if (!ModelState.IsValid)

                return View(originalProvincia);
            _entities.DeleteObject(provinciaToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllProvinces");

        }

        #endregion

        

    }
}
