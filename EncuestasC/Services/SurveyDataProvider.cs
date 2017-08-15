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




        public IEnumerable<CPSPx> GetAllCpsp()
        {
            return _commonDataRepository.GetAllCpsp();
        }

        public IEnumerable<Telefonox> GetTelephones(decimal idCpsp)
        {
            return _commonDataRepository.GetTelephones(idCpsp);
        }


        //public Provincia GetProvince(int provinceId)
        //{
        //    return _commonDataRepository.GetProvince(provinceId);
        //}

        public IEnumerable<Emailx> GetEmails(decimal idCpsp)
        {
            return _commonDataRepository.GetEmails(idCpsp);
        }


        public CodigoPresupuestariox GetCodigoPresupuestario(decimal cpspId)
        {
            return _commonDataRepository.GetCodigoPresupuestario(cpspId);
        }


        public SurveyDtoModel GetCpspInfo(decimal cpspId)
        {
            return _commonDataRepository.GetCpspInfo(cpspId);
        }
    }
}