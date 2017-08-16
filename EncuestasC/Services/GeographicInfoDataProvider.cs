using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EncuestasC.Data;
using EncuestasC.Models;

namespace EncuestasC.Services
{
    public class GeographicInfoDataProvider
    {
        private readonly CommonDataRepository _commonDataRepository;

        public GeographicInfoDataProvider()
        {
            _commonDataRepository = new CommonDataRepository();
        }

        public IEnumerable<LocationInfoDtoModel> GetAllProvinces()
        {
            var provincesList = _commonDataRepository.GetAllProvinces().ToList();
            var provincesDtoList = new List<LocationInfoDtoModel>();
            provincesList.ForEach(cp => provincesDtoList.Add(new LocationInfoDtoModel
            {
                Id = cp.Id,
                Nombre = cp.Nombre
            }));
            return provincesDtoList;
        }

        public IEnumerable<LocationInfoDtoModel> GetAllCantones(int? provinceId)
        {

            var cantonesList = provinceId == null
                ? _commonDataRepository.GetAllCantones().ToList()
                : _commonDataRepository.GetAllCantones(provinceId).ToList();

                var cantonesDtoList = new List<LocationInfoDtoModel>();
                cantonesList.ForEach(cp => cantonesDtoList.Add(new LocationInfoDtoModel
                {
                    Id = cp.Id,
                    Nombre = cp.Nombre,
                    ParentId = cp.IdProvincia
                }));
                return cantonesDtoList;
            
        }

        public IEnumerable<LocationInfoDtoModel> GetAllDistrites(int? cantonId)
        {

            var distritesList = cantonId == null
                ? _commonDataRepository.GetAllDistrites().ToList()
                : _commonDataRepository.GetAllDistrites(cantonId).ToList();

            var distritesDtoList = new List<LocationInfoDtoModel>();
            distritesList.ForEach(cp => distritesDtoList.Add(new LocationInfoDtoModel
            {
                Id = cp.Id,
                Nombre = cp.Nombre,
                ParentId = cp.IdCanton
            }));
            return distritesDtoList;

        }
    }
}