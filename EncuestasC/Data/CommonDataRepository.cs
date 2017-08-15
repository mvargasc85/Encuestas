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

        public IEnumerable<Telefonox> GetTelephones(decimal idCpsp)
        {
            var list = _encuestasDbEntities.Telefono.Where(t => t.CPSP.Id == idCpsp);
            return list;
        }

        public IEnumerable<Emailx> GetEmails(decimal idCpsp)
        {
            var list = _encuestasDbEntities.Email.Where(t => t.CPSP.Id == idCpsp);
            return list;
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
                Location = new LocationDtoModel
                {
                    Provincias = GetAllProvinces(),
                    Cantones = GetAllCantons(),
                    Distritos = GetAllDistrites(),
                    Poblados = GetAllTowns()
                }
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
        private IEnumerable<Cantonx> GetAllCantons()
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
    }
}