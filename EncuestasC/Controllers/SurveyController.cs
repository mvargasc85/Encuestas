using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EncuestasC.Models;
using EncuestasC.Services;

namespace EncuestasC.Controllers
{
    public class SurveyController : Controller
    {
        private SurveyDtoModel _survey=new SurveyDtoModel();
        private readonly EncuestasEntitiesx _entities = new EncuestasEntitiesx();

        private readonly SurveyDataProvider _surveyDataProvider = new SurveyDataProvider();

        public ActionResult GetAllSurveys()
        {
           
            return View(_entities.Encuesta.ToList());
        }


        //CREAR
        public ActionResult CreateSurvey()
        {
            //_survey = new SurveyDtoModel();
            var cpsps = _surveyDataProvider.GetAllCpsp();
          
            _survey.CpspList = new SelectList(cpsps, "Id", "Nombre");
         
            return View(_survey);
        }

        //
        // POST: /GeographicInfo/CreateCanton

        [HttpPost]
        public ActionResult CreateSurvey(Encuestax surveyToCreate)
        {
            try
            {
                _entities.AddToEncuesta(surveyToCreate);
                _entities.SaveChanges();
                return RedirectToAction("GetAllSurveys");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditSurvey(int id)
        {
            var surveyToEdit= _entities.Encuesta.First(m => m.Id == id);
            
            return View(surveyToEdit);
        }

        //
        // POST: /GeographicInfo/EditCanton/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditSurvey(Encuestax surveyToEdit)
        {
            var originalSurvey = _entities.Encuesta.First(m => m.Id == surveyToEdit.Id);
            
            if (!ModelState.IsValid)

                return View(originalSurvey);

            _entities.ApplyCurrentValues(originalSurvey.EntityKey.EntitySetName, surveyToEdit);

            _entities.SaveChanges();

            return RedirectToAction("GetAllSurveys");


        }


        public ActionResult GetTelephones(decimal cpspId)
        {
            var telephones = _surveyDataProvider.GetTelephones(cpspId);

            return PartialView(telephones);
        }

        public ActionResult GetEmails(decimal cpspId)
        {
            var emails = _surveyDataProvider.GetEmails(cpspId);

            return PartialView(emails);
        }

    }
}
