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


        public IEnumerable<CodigoPresupuestariox> GetAllCodPres()
        {
            var list = _encuestasDbEntities.CodigoPresupuestario.Select(p => p);
            return list;
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

        public IEnumerable<Emailx> GetEmails(decimal idCpsp)
        {
            var list = _encuestasDbEntities.Email.Where(t => t.CPSP.Id == idCpsp);
            return list;
        }

        public IEnumerable<CodigoPresupuestariox> GetCodigoPresupuestario()
        {
            return _encuestasDbEntities.CodigoPresupuestario.Select(cp => cp);

        }

        public CPSPx GetCpspInfo(decimal cpspId)
        {
            var cpsp = GetAllCpsp().Single(c => c.Id == cpspId);
            return cpsp;
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

        public IEnumerable<Distritox> GetAllDistrites()
        {
            var list = _encuestasDbEntities.Distrito.Select(p => p);
            return list;
        }

        public IEnumerable<Cantonx> GetAllCantones(int? provinceId)
        {
            return GetAllCantones().Where(c => c.IdProvincia == provinceId);
        }

        public IEnumerable<Distritox> GetAllDistrites(int? cantonId)
        {
            return GetAllDistrites().Where(c => c.IdCanton == cantonId);
        }

        public IEnumerable<EstadoServiciox> GetServiceStatus()
        {
            return _encuestasDbEntities.EstadoServicio.Select(e => e);
        }

        public IEnumerable<Proyectox> GetProjects()
        {
            return _encuestasDbEntities.Proyecto.Select(e => e);
        }

        public Emailx GetEmail(int? emailId)
        {
            return _encuestasDbEntities.Email.Single(e => e.Id == emailId);
        }

        public int SaveEmail(Emailx email)
        {
            try
            {
                if (email.Id == 0)
                {
                    _encuestasDbEntities.AddToEmail(email);
                    _encuestasDbEntities.SaveChanges();
                    return 0;
                }

                var originalEmail = _encuestasDbEntities.Email.First(m => m.Id == email.Id);
                _encuestasDbEntities.ApplyCurrentValues(originalEmail.EntityKey.EntitySetName, email);
                _encuestasDbEntities.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public int CreateSurvey(Encuestax survey)
        {
            try
            {
                _encuestasDbEntities.AddToEncuesta(survey);
                _encuestasDbEntities.SaveChanges();
                return 0;
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}