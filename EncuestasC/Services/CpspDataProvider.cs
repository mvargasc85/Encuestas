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
                cpsp.Nombre = cpspModel.Nombre;
                cpsp.IdProvincia = cpspModel.ProvinciaId;
                cpsp.IdCanton = cpspModel.CantonId;
                cpsp.IdDistrito = cpspModel.DistritoId;


                _commonDataRepository.CreateCpsp(cpsp);

                return "Creada exitosamente";
            }
            catch (Exception e)
            {
                return string.Format("Error al crear la encuesta. Detalles: {0}", e.Message);
            }
        }

        public string EditCPSP(CpspDtoModel cpspToEdit)
        {
            try
            {
                var cpsp = new CPSPx
                {
                    Id = cpspToEdit.Id,
                    Nombre = cpspToEdit.Nombre,
                    IdProvincia = cpspToEdit.ProvinciaId,
                    IdCanton = cpspToEdit.CantonId,
                    IdDistrito = cpspToEdit.DistritoId
                };
                _commonDataRepository.SaveCpsp(cpsp);

                return "Creado exitosamente";

            }
            catch (Exception e)
            {
                return string.Format("Error al crear el CPSP. Detalles: {0}", e.Message);
            }

        }

       
    }
}