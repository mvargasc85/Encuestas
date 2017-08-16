using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EncuestasC.Models;
using EncuestasC.Services;
using Newtonsoft.Json;

namespace EncuestasC.Controllers
{
    public class GeographicInfoController : Controller
    {

        private EncuestasEntitiesx _entities = new EncuestasEntitiesx();
        private readonly GeographicInfoDataProvider _geographicInfoDataProvider = new GeographicInfoDataProvider();

        #region Provincia


        public string GetAllProvicesData()
        {
            var provincesInfo = _geographicInfoDataProvider.GetAllProvinces();
            return JsonConvert.SerializeObject(provincesInfo);
        }

        public string GetAllCantonesData(int? provinceId)
        {
            var cantonesInfo = _geographicInfoDataProvider.GetAllCantones(provinceId);
            return JsonConvert.SerializeObject(cantonesInfo);
        }
        //PEQUEÑLO DETALLE :p
        public string GetAllDistritesData(int? cantonId)
        {
            var cantonesInfo = _geographicInfoDataProvider.GetAllDistrites(cantonId);
            return JsonConvert.SerializeObject(cantonesInfo);
        }


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

            _entities.ApplyCurrentValues(originalProvincia.EntityKey.EntitySetName, provinciaToEdit);

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

        #region Canton

        //Datos para canton
        //LIST
        public ActionResult GetAllCantons()
        {
            return View(_entities.Canton.ToList());

        }
        //CREAR
        public ActionResult CreateCanton()
        {
            return View();
        }

        //
        // POST: /GeographicInfo/CreateCanton

        [HttpPost]
        public ActionResult CreateCanton(Cantonx cantonToCreate)
        {
            try
            {
                _entities.AddToCanton(cantonToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllCantons");
            }
            catch
            {
                return View();
            }
        }
        //EDITAR
        public ActionResult EditCanton(int id)
        {
            var cantonToEdit = (from m in _entities.Canton
                where m.Id == id
                select m).First();
            return View(cantonToEdit);
        }

        //
        // POST: /GeographicInfo/EditCanton/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditCanton(Cantonx cantonToEdit)
        {

            // TODO: Add update logic here
            var originalCanton = (from m in _entities.Canton
                where m.Id == cantonToEdit.Id
                select m).First();

            
            if (!ModelState.IsValid)

                return View(originalCanton);

            _entities.ApplyCurrentValues(originalCanton.EntityKey.EntitySetName, cantonToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllCantons");


        }

        //
        // GET: /GeographicInfo/DeleteCanton/5
        //BORRAR
        public ActionResult DeleteCanton(int id)
        {
            var cantonToDelete = (_entities.Canton.Where(m => m.Id == id)).First();
            return View(cantonToDelete);
        }

        //
        // POST: /GeographicInfo/DeleteCanton/5

        [HttpPost]
        public ActionResult DeleteCanton(Cantonx cantonToDelete)
        {
            cantonToDelete = _entities.Canton.First(m => m.Id == cantonToDelete.Id);
            
            if (!ModelState.IsValid)

                return View(cantonToDelete);
            _entities.DeleteObject(cantonToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllCantons");

        }

        #endregion

        #region District

        

        #endregion

        #region Town

        

        #endregion


    }
}
