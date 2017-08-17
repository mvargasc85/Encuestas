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




        public ActionResult GetAllEstServ()
        {
            return View(_entities.EstadoServicio.ToList());
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
        public ActionResult CreateEstServ()
        {
            return View();
        }

        //
        // POST: /GeographicInfo/CreateProvince

        [HttpPost]
        public ActionResult CreateEstServ(EstadoServiciox EstServToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToEstadoServicio(EstServToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllEstServ");
            }
            catch
            {
                return View();
            }
        }

        //EDITAR
        public ActionResult EditEstServ(int id)
        {
            var EstServToEdit = _entities.EstadoServicio.First(m => m.Id == id);
            return View(EstServToEdit);
        }

        //
        // POST: /GeographicInfo/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditEstServ(EstadoServiciox EstServToEdit)
        {

            // TODO: Add update logic here
            var originalEstServ = _entities.EstadoServicio.First(m => m.Id == EstServToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalEstServ);

            _entities.ApplyCurrentValues(originalEstServ.EntityKey.EntitySetName, EstServToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllEstServ");


        }

        //
        // GET: /GeographicInfo/Delete/5
        //BORRAR
        public ActionResult DeleteEstServ(int id)
        {
            var EstServToDelete = _entities.EstadoServicio.First(m => m.Id == id);
            return View(EstServToDelete);
        }

        //
        // POST: /GeographicInfo/DeleteProvince/5

        [HttpPost]
        public ActionResult DeleteEstServ(EstadoServiciox EstServToDelete)
        {
            EstServToDelete = _entities.EstadoServicio.First(m => m.Id == EstServToDelete.Id);

            if (!ModelState.IsValid)
                return View(EstServToDelete);

            _entities.DeleteObject(EstServToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllEstServ");

        }



        public ActionResult GetAllProyecto()
        {
            return View(_entities.Proyecto.ToList());
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
        public ActionResult CreateProyecto()
        {
            return View();
        }

        //
        // POST: /GeographicInfo/CreateProvince

        [HttpPost]
        public ActionResult CreateProyecto(Proyectox ProyectoToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToProyecto(ProyectoToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllProyecto");
            }
            catch
            {
                return View();
            }
        }

        //EDITAR
        public ActionResult EditProyecto(int id)
        {
            var ProyectoToEdit = _entities.Proyecto.First(m => m.Id == id);
            return View(ProyectoToEdit);
        }

        //
        // POST: /GeographicInfo/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditProyecto(Proyectox ProyectoToEdit)
        {

            // TODO: Add update logic here
            var originalProyecto = _entities.Proyecto.First(m => m.Id == ProyectoToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalProyecto);

            _entities.ApplyCurrentValues(originalProyecto.EntityKey.EntitySetName, ProyectoToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllProyecto");


        }

        //
        // GET: /GeographicInfo/Delete/5
        //BORRAR
        public ActionResult DeleteProyecto(int id)
        {
            var ProyectoToDelete = _entities.Proyecto.First(m => m.Id == id);
            return View(ProyectoToDelete);
        }

        //
        // POST: /GeographicInfo/DeleteProvince/5

        [HttpPost]
        public ActionResult DeleteProyecto(Proyectox ProyectoToDelete)
        {
            ProyectoToDelete = _entities.Proyecto.First(m => m.Id == ProyectoToDelete.Id);

            if (!ModelState.IsValid)
                return View(ProyectoToDelete);

            _entities.DeleteObject(ProyectoToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllProyecto");

        }

    }
}
