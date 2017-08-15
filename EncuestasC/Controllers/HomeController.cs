using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EncuestasC.Models;

namespace EncuestasC.Controllers
{
    public class HomeController : Controller
    {
        private EncuestasEntities _entities = new EncuestasEntities();


        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();

        }


       
      
        //Datos para cod presupuestario
        //LIST
        public ActionResult DCodPres()
        {
            return View(_entities.CodigoPresupuestario.ToList());

        }
        //CREAR
        public ActionResult CCodPres()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult CCodPres(CodigoPresupuestariox codigoPresupuestarioToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToCodigoPresupuestario(codigoPresupuestarioToCreate);
                _entities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5
        //EDITAR
        public ActionResult ECodPres(int Id)
        {
            var CodigoPresupuestarioToEdit = (from m in _entities.CodigoPresupuestario
                                              where m.Id == Id
                                              select m).First();
            return View(CodigoPresupuestarioToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ECodPres(CodigoPresupuestariox codigoPresupuestarioToEdit)
        {

            // TODO: Add update logic here
            var originalCodigoPresupuestario = (from m in _entities.CodigoPresupuestario
                                                where m.Id == codigoPresupuestarioToEdit.Id
                                                select m).First();



            if (!ModelState.IsValid)

                return View(originalCodigoPresupuestario);

            _entities.ApplyPropertyChanges(originalCodigoPresupuestario.EntityKey.EntitySetName, codigoPresupuestarioToEdit);

            _entities.SaveChanges();

            return RedirectToAction("Index");


        }

        //
        // GET: /Home/Delete/5
        //BORRAR
        public ActionResult BCodPres(int Id)
        {
            var CodPresToDelete = (from m in _entities.Canton
                                  where m.Id == Id
                                  select m).First();
            return View(CodPresToDelete);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult BCodPres(CodigoPresupuestariox codigoPresupuestarioToDelete)
        {

            var originalCodigoPresupuestario = (from m in _entities.Distrito
                                    where m.Id == codigoPresupuestarioToDelete.Id
                                    select m).First();



            if (!ModelState.IsValid)

                return View(originalCodigoPresupuestario);
            _entities.DeleteObject(codigoPresupuestarioToDelete);

            _entities.SaveChanges();

            return RedirectToAction("DCodPres");
        }

        //Datos para distrito
        //LIST
        public ActionResult DDistrito()
        {
            return View(_entities.Distrito.ToList());

        }
        //CREAR
        public ActionResult CDistrito()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult CDistrito(Distritox DistritoToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToDistrito(DistritoToCreate);
                _entities.SaveChanges();
                return RedirectToAction("DDistrito");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5
        //EDITAR
        public ActionResult Edistrito(int Id)
        {
            var DistritoToEdit = (from m in _entities.Distrito
                                              where m.Id == Id
                                              select m).First();
            return View(DistritoToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edistrito(Distritox distritoToEdit)
        {

            // TODO: Add update logic here
            var originalDistrito = (from m in _entities.Distrito
                                    where m.Id == distritoToEdit.Id
                                                select m).First();



            if (!ModelState.IsValid)

                return View(originalDistrito);

            _entities.ApplyPropertyChanges(originalDistrito.EntityKey.EntitySetName, distritoToEdit);

            _entities.SaveChanges();

            return RedirectToAction("DDistrito");


        }

        //
        // GET: /Home/Delete/5
        //BORRAR
        public ActionResult BDistrito(int Id)
        {
            var DistritoToDelete = (from m in _entities.Distrito
                                   where m.Id == Id
                                   select m).First();
            return View(DistritoToDelete);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult BDistrito(Distritox distritoToDelete)
        {
            var originalDistrito = (from m in _entities.Distrito
                                    where m.Id == distritoToDelete.Id
                                    select m).First();



            if (!ModelState.IsValid)

                return View(originalDistrito);
            _entities.DeleteObject(distritoToDelete);

            _entities.SaveChanges();

            return RedirectToAction("DDistrito");
        }

        //Datos para Estado Servicio
        //LIST
        public ActionResult DEstServ()
        {
            return View(_entities.EstadoServicio.ToList());

        }
        //CREAR
        public ActionResult CEstServ()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult CEstServ(EstadoServiciox EstadoServicioToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToEstadoServicio(EstadoServicioToCreate);
                _entities.SaveChanges();
                return RedirectToAction("DEstServ");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5
        //EDITAR
        public ActionResult EEstServ(int Id)
        {
            var EstadoServicioToEdit = (from m in _entities.EstadoServicio
                                  where m.Id == Id
                                  select m).First();
            return View(EstadoServicioToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EEstServ(EstadoServiciox EstadoServicioToEdit)
        {

            // TODO: Add update logic here
            var originalEstadoServicio = (from m in _entities.EstadoServicio
                                          where m.Id == EstadoServicioToEdit.Id
                                    select m).First();



            if (!ModelState.IsValid)

                return View(originalEstadoServicio);

            _entities.ApplyPropertyChanges(originalEstadoServicio.EntityKey.EntitySetName, EstadoServicioToEdit);

            _entities.SaveChanges();

            return RedirectToAction("DEstServ");


        }

        //
        // GET: /Home/Delete/5
        //BORRAR
        public ActionResult BEstServ(int Id)
        {
            var EstadoServicioToDelete = (from m in _entities.EstadoServicio
                                    where m.Id == Id
                                    select m).First();
            return View(EstadoServicioToDelete);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult BEstServ(EstadoServiciox EstadoServicioToDelete)
        {
            var originalEstadoServicio = (from m in _entities.EstadoServicio
                                          where m.Id == EstadoServicioToDelete.Id
                                    select m).First();



            if (!ModelState.IsValid)

                return View(originalEstadoServicio);
            _entities.DeleteObject(EstadoServicioToDelete);

            _entities.SaveChanges();

            return RedirectToAction("DEstServ");
        }

        //Datos para Poblado
        //LIST
        public ActionResult DPoblado()
        {
            return View(_entities.Poblado.ToList());

        }
        //CREAR
        public ActionResult CPoblado()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult CPoblado(Pobladox PobladoToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToPoblado(PobladoToCreate);
                _entities.SaveChanges();
                return RedirectToAction("DPoblado");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5
        //EDITAR
        public ActionResult EPoblado(int Id)
        {
            var PobladoToEdit = (from m in _entities.Poblado
                                        where m.Id == Id
                                        select m).First();
            return View(PobladoToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EPoblado(Pobladox PobladoToEdit)
        {

            // TODO: Add update logic here
            var originalPoblado = (from m in _entities.Poblado
                                   where m.Id == PobladoToEdit.Id
                                          select m).First();



            if (!ModelState.IsValid)

                return View(originalPoblado);

            _entities.ApplyPropertyChanges(originalPoblado.EntityKey.EntitySetName, PobladoToEdit);

            _entities.SaveChanges();

            return RedirectToAction("DPoblado");


        }

        //
        // GET: /Home/Delete/5
        //BORRAR
        public ActionResult BPoblado(int Id)
        {
            var PobladoToDelete = (from m in _entities.Poblado
                                          where m.Id == Id
                                          select m).First();
            return View(PobladoToDelete);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult BPoblado(Pobladox PobladoToDelete)
        {
            var originalPoblado = (from m in _entities.Poblado
                                   where m.Id == PobladoToDelete.Id
                                          select m).First();



            if (!ModelState.IsValid)

                return View(originalPoblado);
            _entities.DeleteObject(PobladoToDelete);

            _entities.SaveChanges();

            return RedirectToAction("DPoblado");
        } 
       
    }
}
