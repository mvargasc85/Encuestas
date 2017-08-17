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
    public class MaintenanceController : Controller
    {
        private CodPresDtoModel _codpres = new CodPresDtoModel();
         private EncuestasEntitiesx _entities = new EncuestasEntitiesx();
         private readonly MaintenanceDataProvider _maintenanceDataProvider = new MaintenanceDataProvider();


         public ActionResult GetAllCodPres()
         {
             return View(_entities.CodigoPresupuestario.ToList());
         }

        ////LIST
        //public string GetCodPresList()
        //{
        //    //return View(_entities.CodigoPresupuestario.ToList());
        //    var codpresList = _maintenanceDataProvider.GetAllCodPres();

        //    //_codpres.Id = new SelectList(cpsps, "Id", "Nombre");

        //  // ya

        //    return JsonConvert.SerializeObject(codpresList);
        //}

        //CREAR
        public ActionResult CreateCodPres()
        {
            return View();
        }

        //
        // POST: /GeographicInfo/CreateProvince

        [HttpPost]
        public ActionResult CreateCodPres(CodigoPresupuestariox CodPresToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToCodigoPresupuestario(CodPresToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllCodPres");
            }
            catch
            {
                return View();
            }
        }

        //EDITAR
        public ActionResult EditCodPres(int id)
        {
            var codPresToEdit = _entities.CodigoPresupuestario.First(m => m.Id == id);
            return View(codPresToEdit);
        }

        //
        // POST: /GeographicInfo/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditCodPres(CodigoPresupuestariox codPresToEdit)
        {

            // TODO: Add update logic here
            var originalCodPres = _entities.CodigoPresupuestario.First(m => m.Id == codPresToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalCodPres);

            _entities.ApplyCurrentValues(originalCodPres.EntityKey.EntitySetName, codPresToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllCodPres");


        }

        //
        // GET: /GeographicInfo/Delete/5
        //BORRAR
        public ActionResult DeleteCodPres(int id)
        {
            var codPresToDelete = _entities.CodigoPresupuestario.First(m => m.Id == id);
            return View(codPresToDelete);
        }

        //
        // POST: /GeographicInfo/DeleteProvince/5

        [HttpPost]
        public ActionResult DeleteCodPres(CodigoPresupuestariox codPresToDelete)
        {
            codPresToDelete = _entities.CodigoPresupuestario.First(m => m.Id == codPresToDelete.Id);

            if (!ModelState.IsValid)
                return View(codPresToDelete);

            _entities.DeleteObject(codPresToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllCodPres");

        }

    

    }
}
