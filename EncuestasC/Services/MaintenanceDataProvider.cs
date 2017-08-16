using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using EncuestasC.Data;
using EncuestasC.Models;

namespace EncuestasC.Services
{
    public class MaintenanceDataProvider
    {
        private readonly CommonDataRepository _commonDataRepository;

        public MaintenanceDataProvider()
        {
            _commonDataRepository = new CommonDataRepository();
        }




        public IEnumerable<CodPresDtoModel> GetAllCodPres()
        {
            return _commonDataRepository.GetAllCodPres();
           
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