using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using EncuestasC.Data;
using EncuestasC.Models;

namespace EncuestasC.Services
{
    public class SurveyDataProvider
    {
        private readonly CommonDataRepository _commonDataRepository;

        public SurveyDataProvider()
        {
            _commonDataRepository = new CommonDataRepository();
        }




        public IEnumerable<CpspDtoModel> GetAllCpsp()
        {
            var cpspList = _commonDataRepository.GetAllCpsp().ToList();
            var cpspDtoList = new List<CpspDtoModel>();
            cpspList.ForEach(cp => cpspDtoList.Add(new CpspDtoModel
            {
                Id = cp.Id,
                Nombre = cp.Nombre
            }));
            return cpspDtoList;
        }

        public IEnumerable<TelephoneDtoModel> GetTelephones(decimal idCpsp)
        {
            return _commonDataRepository.GetTelephones(idCpsp);
        }


        //public Provincia GetProvince(int provinceId)
        //{
        //    return _commonDataRepository.GetProvince(provinceId);
        //}

        public IEnumerable<EmailDtoModel> GetEmails(decimal idCpsp)
        {
            var list = _commonDataRepository.GetEmails(idCpsp).ToList();
            var emailDtoList = new List<EmailDtoModel>();

            list.ForEach(emailx => emailDtoList.Add(new EmailDtoModel
            {
                Id = emailx.Id,
                Nombre = emailx.Nombre,
                Correo = emailx.Correo,
                NombreCorreo = string.Format("{0} <{1}>", emailx.Nombre, emailx.Correo)
            }));

            emailDtoList.Add(new EmailDtoModel {Id = -1,Nombre = "Otra",NombreCorreo = "Otra"});
            return emailDtoList;
        }


        public CodigoPresupuestariox GetCodigoPresupuestario(decimal cpId)
        {
            return _commonDataRepository.GetCodigoPresupuestario().Single(cp => cp.Id == cpId);
        }


        public SurveyDtoModel GetCpspInfo(decimal cpspId)
        {
            var cpsp = _commonDataRepository.GetCpspInfo(cpspId);
            var surveryDtoModel = new SurveyDtoModel
            {
                Id = cpspId,
                Emails = GetEmails(cpspId),
                Telefonos = GetTelephones(cpspId),
                Location = new LocationDtoModel
                {
                    Provincia = CreateLocationInfo(cpsp.Provincia.Id, cpsp.Provincia.Nombre, null),
                    Canton = CreateLocationInfo(cpsp.Canton.Id, cpsp.Canton.Nombre, cpsp.Canton.IdProvincia),
                    Distrito = CreateLocationInfo(cpsp.Distrito.Id, cpsp.Distrito.Nombre, cpsp.Distrito.IdCanton)
                },
                EstadosServicio = GetServiceStatusDtoModel(),
                CodPresupuestarios = GetCodPresDtoModel(),
                Proyectos = GetProjectDtoModel()
            };

            return surveryDtoModel;

        }

        private IEnumerable<ProyectoDtoModel> GetProjectDtoModel()
        {
            var project = _commonDataRepository.GetProjects().ToList();
            var codPresDto = new List<ProyectoDtoModel>();
            project.ForEach(cp => codPresDto.Add(new ProyectoDtoModel
            {
                Id = cp.Id,
                Nombre = cp.Nombre,
                Detalle = cp.Detalle
            }));
            return codPresDto;
        }

        private IEnumerable<EstadoServicioDtoModel> GetServiceStatusDtoModel()
        {
            var serviceStatusList = _commonDataRepository.GetServiceStatus().ToList();
            var statusDtoList = new List<EstadoServicioDtoModel>();
            serviceStatusList.ForEach(cp => statusDtoList.Add(new EstadoServicioDtoModel
            {
                Id = cp.Id,
                Estado = cp.Estado
            }));
            return statusDtoList;
        }

        private LocationInfoDtoModel CreateLocationInfo(int id, string name, int? parentId)
        {
            return new LocationInfoDtoModel
            {
                Id = id,
                Nombre = name,
                ParentId = parentId
            };
        }

        public IEnumerable<CodPresupuestarioDtoModel> GetCodPresDtoModel()
        {
            var codes = _commonDataRepository.GetCodigoPresupuestario().ToList();
            var codPresDto = new List<CodPresupuestarioDtoModel>();
            codes.ForEach(cp => codPresDto.Add(new CodPresupuestarioDtoModel
            {
                Id = cp.Id,
                Codigo = cp.Codigo
            }));
            return codPresDto;
        }

        public string CreateSurvey(SurveyDtoModel surveyModel)
        {
            try
            {
                var survey = new Encuestax();
                survey.IdCPSP = surveyModel.CpsPId;
                survey.ContestaLlamada = surveyModel.Contesta;

                if (survey.ContestaLlamada == "S")
                {
                    survey.IdProyecto = surveyModel.ProyectoId;
                    survey.IdCodigoPresupuestario = surveyModel.CodPresupuestarioId;
                    var email = surveyModel.EmailId == null
                        ? SaveEmail(0, surveyModel.CpsPId, surveyModel.EmailNuevoContacto,
                            surveyModel.NombreNuevoContacto)
                        : _commonDataRepository.GetEmail(surveyModel.EmailId);

                    survey.IdEmail = email.Id;
                    survey.NombreContacto = email.Nombre;
                    survey.IdEstadoServicio = surveyModel.EstadoServicioId;
                    survey.Comentarios = surveyModel.Comentarios;
                }

               _commonDataRepository.CreateSurvey(survey);
               
                return "Creada exitosamente";
            }
            catch (Exception e)
            {
                return string.Format("Error al crear la encuesta. Detalles: {0}", e.Message);
            }
        }

        public Emailx SaveEmail(int id, int? cpspId, string correo, string nombre)
        {
            var email = id == 0 ? new Emailx() : _commonDataRepository.GetEmail(id);

            email.IdCPSP = cpspId;
            email.Nombre = nombre;
            email.Correo = correo;
            _commonDataRepository.SaveEmail(email);
            return email;

        }
    }
}