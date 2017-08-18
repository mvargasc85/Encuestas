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

  

public string CreateCPSP(CpspDtoModel cpspModel)
        {
            try
            {
                var cpsp = new CPSPx();

                cpsp.IdProvincia = cpspModel.Provincia.Id;
                cpsp.IdCanton = cpspModel.Canton.Id;
                cpsp.IdDistrito = cpspModel.Distrito.Id;
               

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