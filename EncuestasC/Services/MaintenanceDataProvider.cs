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
           var list = _commonDataRepository.GetAllCodPres().ToList();
           var codPresList = new List<CodPresDtoModel>();
           list.ForEach(cp => codPresList.Add(new CodPresDtoModel
           {
               Id = cp.Id,
               Codigo = cp.Codigo
           }));
           return codPresList; //listo
       }


    }
}