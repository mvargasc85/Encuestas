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
        public ActionResult CreateProvince()
        {
            return View();
        }

        //
        // POST: /GeographicInfo/CreateProvince

        [HttpPost]
        public ActionResult CreateProvince(Provinciax provinceToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToProvincia(provinceToCreate);
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
        // POST: /GeographicInfo/Edit/5

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
        // GET: /GeographicInfo/Delete/5
        //BORRAR
        public ActionResult DeleteProvince(int id)
        {
            var provinciaToDelete = _entities.Provincia.First(m => m.Id == id);
            return View(provinciaToDelete);
        }

        //
        // POST: /GeographicInfo/DeleteProvince/5

        [HttpPost]
        public ActionResult DeleteProvince(Provinciax provinceToDelete)
        {
            provinceToDelete = _entities.Provincia.First(m => m.Id == provinceToDelete.Id);

            if (!ModelState.IsValid)
                return View(provinceToDelete);

            _entities.DeleteObject(provinceToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllProvinces");

        }

        #endregion

        

    }
}
