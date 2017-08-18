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


        public IEnumerable<CpspDtoModel> GetAllCpsp()
        {
            var list = _commonDataRepository.GetAllCpsp().ToList();
            var cpspDtoList = new List<CpspDtoModel>();
            foreach (var cp in list)
                cpspDtoList.Add(new CpspDtoModel
                {
                    Id = cp.Id,
                    Nombre = cp.Nombre,
                    Provincia = GetProvincia(cp.IdProvincia),
                    Canton = GetCanton(cp.IdCanton),
                    Distrito = GetDistrito(cp.IdDistrito)
                });

            return cpspDtoList;
        }


        public LocationInfoDtoModel GetProvincia(int? provinceId)
        {
            var model = _commonDataRepository.GetAllProvinces().Single(p => p.Id == provinceId);
            return new LocationInfoDtoModel
            {
                Id = model.Id,
                Nombre = model.Nombre
            };
        }

        public LocationInfoDtoModel GetCanton(int? cantonId)
        {
            var model = _commonDataRepository.GetAllCantones().Single(p => p.Id == cantonId);

            return new LocationInfoDtoModel
            {
                Id = model.Id,
                Nombre = model.Nombre
            };
        }

        public LocationInfoDtoModel GetDistrito(int? distrito)
        {
            var model = _commonDataRepository.GetAllDistrites().Single(p => p.Id == distrito);

            return new LocationInfoDtoModel
            {
                Id = model.Id,
                Nombre = model.Nombre
            };
        }
    }
}