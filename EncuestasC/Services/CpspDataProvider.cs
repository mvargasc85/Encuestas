using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using EncuestasC.Data;
using EncuestasC.Models;

namespace EncuestasC.Services
{
    public class CpspDataProvider
    {
        private readonly CommonDataRepository _commonDataRepository;

        public CpspDataProvider()
        {
            _commonDataRepository = new CommonDataRepository();
        }

  

public string CreateCPSP(CpspDtoModel CPSPModel)
        {
            try
            {
                var cpsp = new CPSPx();
                cpsp.Id = CPSPModel.Id;
              
                    cpsp.IdProvincia = CPSPModel.Provincia.Id;
                cpsp.IdCanton = CPSPModel.Canton.Id;
                   cpsp.IdDistrito = CPSPModel.Distrito.Id;
               

               _commonDataRepository.CreateCpsp(cpsp);
               
                return "Creada exitosamente";
            }
            catch (Exception e)
            {
                return string.Format("Error al crear la encuesta. Detalles: {0}", e.Message);
            }
        }
    }
}