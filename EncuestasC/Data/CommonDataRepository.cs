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

        //public IEnumerable<Provincia> GetAllProvinces()
        //{
        //    var list = (from p in _encuestasDbEntities.Provincias select p);

        //    return list;
        //}

        //public Provincia GetProvince(int provinceId)
        //{
        //    var province = _encuestasDbEntities.Provincias.FirstOrDefault(p => p.Id == provinceId);
        //    return province;
        //}


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
    }
}