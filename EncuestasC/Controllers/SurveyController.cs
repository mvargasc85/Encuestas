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
    public class SurveyController : Controller
    {
        private SurveyDtoModel _survey = new SurveyDtoModel();
        private readonly EncuestasEntitiesx _entities = new EncuestasEntitiesx();

        private readonly SurveyDataProvider _surveyDataProvider = new SurveyDataProvider();

        public ActionResult GetAllSurveys()
        {
            var survey = _entities.Encuesta.ToList();
            //foreach (var item in survey)
            //{
            //    item.Email = item.IdEmail == null ? null : _entities.Email.Single(e => e.Id == item.IdEmail);
            //    item.Proyecto = item.IdProyecto == null ? null : _entities.Proyecto.Single(e => e.Id == item.IdProyecto);
            //}
            return View(survey);
        }


        //CREAR
        public ActionResult CreateSurvey()
        {
            ////_survey = new SurveyDtoModel();
            //var cpsps = _surveyDataProvider.GetAllCpsp();

            //_survey.CpspList = new SelectList(cpsps, "Id", "Nombre");

            return View();
        }

        //
        // POST: /GeographicInfo/CreateCanton

        [HttpPost]
        public ActionResult CreateSurvey(SurveyDtoModel surveyToCreate)
        {
            try
            {
                _surveyDataProvider.CreateSurvey(surveyToCreate);
                return RedirectToAction("GetAllSurveys");
            }
            catch
            {
                return RedirectToAction("GetAllSurveys");
            }
        }

        public ActionResult EditSurvey(int id)
        {
            var surveyToEdit = _entities.Encuesta.First(m => m.Id == id);

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

        [ActionName("GetCpspInfo")]
        public string GetCpspInfo(decimal cpspId)
        {
            var cpspInfo = _surveyDataProvider.GetCpspInfo(cpspId);
            return JsonConvert.SerializeObject(cpspInfo);
            
        }


        public string GetAllCpsp()
        {
            var cpspList =_surveyDataProvider.GetAllCpsp();
            return JsonConvert.SerializeObject(cpspList);
        }

}
}
