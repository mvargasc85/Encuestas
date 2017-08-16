using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EncuestasC.Models
{
    public class SurveyDtoModel
    {
        public decimal Id { get; set; }
        public Proyectox Proyecto { get; set; }
        public CPSPx CpsP { get; set; }
        public CodigoPresupuestariox CodigoPresupuestario { get; set; }
        public IEnumerable<TelephoneDtoModel> Telefonos { get; set; }
        public IEnumerable<EmailDtoModel> Emails { get; set; }
        public EstadoServiciox EstadoServicio { get; set; }
        public string Comentarios { get; set; }
        public string NombreContacto { get; set; }
        public char Contesta { get; set; }
        public SelectList CpspList { get; set; }
        public LocationDtoModel Location { get; set; }

    }


    public class LocationDtoModel
    {
        public IEnumerable<Provinciax> Provincias { get; set; }
        public IEnumerable<Cantonx> Cantones { get; set; }
        public IEnumerable<Distritox> Distritos { get; set; }
        public IEnumerable<Pobladox> Poblados { get; set; }
        public decimal? ProvinciaId { get; set; }
        public decimal? CantonId { get; set; }
        public decimal? DistritoId { get; set; }
        public decimal? PobladosId { get; set; }

    }

    public class CpspDtoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class EmailDtoModel
    {
        public int Id { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
    }

    public class TelephoneDtoModel
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public int? IdCpsp { get; set; }
    }

}