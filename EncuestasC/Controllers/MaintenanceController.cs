using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EncuestasC.Models;
using EncuestasC.Services;

namespace EncuestasC.Controllers
{
    public class MaintenanceController : Controller
    {
        private CodPresDtoModel _codpres = new CodPresDtoModel();
         private EncuestasEntitiesx _entities = new EncuestasEntitiesx();
         private readonly MaintenanceDataProvider _maintenanceDataProvider = new MaintenanceDataProvider();
         private readonly CpspDataProvider _CpspDataProvider = new CpspDataProvider();


         public ActionResult GetAllCPSP()
         {
             var cpspList = _maintenanceDataProvider.GetAllCpsp();
            return View(cpspList);

        }
    
         public ActionResult GetAllCodPres()
         {
             return View(_entities.CodigoPresupuestario.ToList());
         }

     

        //CREAR
        public ActionResult CreateCodPres()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult CreateCodPres(CodigoPresupuestariox CodPresToCreate)
        {
            try
            {
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

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditCodPres(CodigoPresupuestariox codPresToEdit)
        {

           var originalCodPres = _entities.CodigoPresupuestario.First(m => m.Id == codPresToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalCodPres);

            _entities.ApplyCurrentValues(originalCodPres.EntityKey.EntitySetName, codPresToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllCodPres");


        }

       //BORRAR
        public ActionResult DeleteCodPres(int id)
        {
            var codPresToDelete = _entities.CodigoPresupuestario.First(m => m.Id == id);
            return View(codPresToDelete);
        }

   
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

    
        //CREAR
        public ActionResult CreateEstServ()
        {
            return View();
        }

    
        [HttpPost]
        public ActionResult CreateEstServ(EstadoServiciox EstServToCreate)
        {
            try
            {
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

     
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditEstServ(EstadoServiciox EstServToEdit)
        {

            var originalEstServ = _entities.EstadoServicio.First(m => m.Id == EstServToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalEstServ);

            _entities.ApplyCurrentValues(originalEstServ.EntityKey.EntitySetName, EstServToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllEstServ");


        }

        //BORRAR
        public ActionResult DeleteEstServ(int id)
        {
            var EstServToDelete = _entities.EstadoServicio.First(m => m.Id == id);
            return View(EstServToDelete);
        }

     
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

    
        //CREAR
        public ActionResult CreateProyecto()
        {
            return View();
        }

       [HttpPost]
        public ActionResult CreateProyecto(Proyectox ProyectoToCreate)
        {
            try
            {
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

     
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditProyecto(Proyectox ProyectoToEdit)
        {

            var originalProyecto = _entities.Proyecto.First(m => m.Id == ProyectoToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalProyecto);

            _entities.ApplyCurrentValues(originalProyecto.EntityKey.EntitySetName, ProyectoToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllProyecto");


        }

        //BORRAR
        public ActionResult DeleteProyecto(int id)
        {
            var ProyectoToDelete = _entities.Proyecto.First(m => m.Id == id);
            return View(ProyectoToDelete);
        }

       
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
        public ActionResult GetAllTelefono()
        {
            return View(_entities.Telefono.ToList());
        }

      

        //CREAR
        public ActionResult CreateTelefono()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult CreateTelefono(Telefonox TelefonoToCreate)
        {
            try
            {
              
                _entities.AddToTelefono(TelefonoToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllTelefono");
            }
            catch
            {
                return View();
            }
        }

        //EDITAR
        public ActionResult EditTelefono(int id)
        {
            var TelefonoToEdit = _entities.Telefono.First(m => m.Id == id);
            return View(TelefonoToEdit);
        }

   
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditTelefono(Telefonox TelefonoToEdit)
        {

            // TODO: Add update logic here
            var originalTelefono = _entities.Telefono.First(m => m.Id == TelefonoToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalTelefono);

            _entities.ApplyCurrentValues(originalTelefono.EntityKey.EntitySetName, TelefonoToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllTelefono");


        }

       
        //BORRAR
        public ActionResult DeleteTelefono(int id)
        {
            var TelefonoToDelete = _entities.Telefono.First(m => m.Id == id);
            return View(TelefonoToDelete);
        }

     
        [HttpPost]
        public ActionResult DeleteTelefono(Telefonox TelefonoToDelete)
        {
            TelefonoToDelete = _entities.Telefono.First(m => m.Id == TelefonoToDelete.Id);

            if (!ModelState.IsValid)
                return View(TelefonoToDelete);

            _entities.DeleteObject(TelefonoToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllTelefono");

        }


        public ActionResult GetAllEmail()
        {
            return View(_entities.Email.ToList());
        }


      

        //CREAR
        public ActionResult CreateEmail()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult CreateEmail(Emailx EmailToCreate)
        {
            try
            {
              
                _entities.AddToEmail(EmailToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllEmail");
            }
            catch
            {
                return View();
            }
        }

        //EDITAR
        public ActionResult EditEmail(int id)
        {
            var EmailToEdit = _entities.Email.First(m => m.Id == id);
            return View(EmailToEdit);
        }

      
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditEmail(Emailx EmailToEdit)
        {

           
            var originalEmail = _entities.Email.First(m => m.Id == EmailToEdit.Id);

            if (!ModelState.IsValid)

                return View(originalEmail);

            _entities.ApplyCurrentValues(originalEmail.EntityKey.EntitySetName, EmailToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllEmail");


        }

        //BORRAR
        public ActionResult DeleteEmail(int id)
        {
            var EmailToDelete = _entities.Email.First(m => m.Id == id);
            return View(EmailToDelete);
        }

   
        [HttpPost]
        public ActionResult DeleteEmail(Emailx EmailToDelete)
        {
            EmailToDelete = _entities.Email.First(m => m.Id == EmailToDelete.Id);

            if (!ModelState.IsValid)
                return View(EmailToDelete);

            _entities.DeleteObject(EmailToDelete);

            _entities.SaveChanges();

            return RedirectToAction("GetAllEmail");

        }

        #region CPSP

        public ActionResult CreateCPSP()
        {
          
            return View();
        }

      
        [HttpPost]
        public ActionResult CreateCPSP(CpspDtoModel CPSPtoCreate)
        {
            try
            {
                _CpspDataProvider.CreateCPSP(CPSPtoCreate);
                return RedirectToAction("GetAllCPSP");
            }
            catch
            {
                return RedirectToAction("GetAllCPSP");
            }
        }

        //public ActionResult EditCPSP(int Id)
        //{
        //    var cpspToEdit = _entities.CPSP.Single(c => c.Id == Id);
        //    var cpspDtoToEdit = new {

        //    }

        //    return View(cpspToEdit);
        //}

        

        [HttpPost]
        public ActionResult EditCPSP(CpspDtoModel CPSPtoEdit)
        {
            try
            {
                _CpspDataProvider.EditCPSP(CPSPtoEdit);
                return RedirectToAction("GetAllCPSP");
            }
            catch
            {
                return RedirectToAction("GetAllCPSP");
            }
        }


        #endregion
    }
}
