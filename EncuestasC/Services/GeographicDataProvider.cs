using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using EncuestasC.Data;
using EncuestasC.Models;

namespace EncuestasC.Services
{
    public class GeographicDataProvider
    {
        private readonly CommonDataRepository _commonDataRepository;

        public GeographicDataProvider()
        {
            _commonDataRepository = new CommonDataRepository();
        }




        public IEnumerable<Provinciax> GetAllProvincia()
        {
            return _commonDataRepository.GetAllProvincia();
        }


        
    }
}