using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EncuestasC.Models;

namespace EncuestasC.Data
{
    public class CommonDataRepository
    {
        private readonly EncuestasEntitiesx _encuestasDbEntities;

        public CommonDataRepository()
        {
            _encuestasDbEntities = new EncuestasEntitiesx();
        }

       


        public IEnumerable<CPSPx> GetAllCpsp()
        {
            var list = _encuestasDbEntities.CPSP.Select(p => p);
            return list;
        }

        public IEnumerable<TelephoneDtoModel> GetTelephones(decimal idCpsp)
        {
            var list = _encuestasDbEntities.Telefono.Where(t => t.CPSP.Id == idCpsp).ToList();
            var phoneList = new List<TelephoneDtoModel>();
            list.ForEach(p => phoneList.Add(new TelephoneDtoModel
            {
                Id = p.Id,
                Telefono = p.Telefono1,
                IdCpsp = p.IdCPSP
            }));
            return phoneList;
        }

        public IEnumerable<EmailDtoModel> GetEmails(decimal idCpsp)
        {
            var list = _encuestasDbEntities.Email.Where(t => t.CPSP.Id == idCpsp).ToList();
            var emailList = new List<EmailDtoModel>();
            foreach (var emailx in list)
            {
                emailList.Add(new EmailDtoModel
                {
                    Id = emailx.Id,
                    Nombre = emailx.Nombre,
                    Correo = emailx.Correo
                });
            }
            return emailList;
        }

        public CodigoPresupuestariox GetCodigoPresupuestario(decimal cpspId)
        {
            var cpsp = GetAllCpsp().FirstOrDefault(c => c.Id == cpspId);
            return null;
            //var codPresupuestario = _encuestasDbEntities.CodigoPresupuestario.FirstOrDefault(cp=> cp.Id==cpsp.)

        }

        public SurveyDtoModel GetCpspInfo(decimal cpspId)
        {
            var surveryDtoModel = new SurveyDtoModel
            {
                Id = cpspId,
                Emails = GetEmails(cpspId),
                Telefonos = GetTelephones(cpspId),
                //Location = new LocationDtoModel
                //{
                //    Provincias = GetAllProvinces(),
                //    Cantones = GetAllCantons(),
                //    Distritos = GetAllDistrites(),
                //    Poblados = GetAllTowns()
                //}
            };

            return surveryDtoModel;
        }

        public IEnumerable<Provinciax> GetAllProvinces()
        {
            var list = _encuestasDbEntities.Provincia.Select(p => p);
            return list;
        }

        public Provinciax GetProvince(int provinceId)
        {
            var province = _encuestasDbEntities.Provincia.SingleOrDefault(p => p.Id == provinceId);
            return province;
        }

        public IEnumerable<Cantonx> GetAllCantones()
        {
            var list = _encuestasDbEntities.Canton.Select(p => p);
            return list;
        }
        private IEnumerable<Distritox> GetAllDistrites()
        {
            var list = _encuestasDbEntities.Distrito.Select(p => p);
            return list;
        }
        private IEnumerable<Pobladox> GetAllTowns()
        {
            var list = _encuestasDbEntities.Poblado.Select(p => p);
            return list;
        }

        public IEnumerable<Cantonx> GetAllCantones(int? provinceId)
        {
            return GetAllCantones().Where(c => c.IdProvincia == provinceId);
        }
    }
}