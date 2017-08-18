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
        public IEnumerable<EstadoServicioDtoModel> EstadosServicio { get; set; }
        public IEnumerable<CodPresupuestarioDtoModel> CodPresupuestarios { get; set; }
        public IEnumerable<ProyectoDtoModel> Proyectos { get; set; }
        public EstadoServicioDtoModel EstadoServicio { get; set; }
        public string Comentarios { get; set; }
        public string NombreContacto { get; set; }
        public char Contesta { get; set; }
        public SelectList CpspList { get; set; }
        public LocationDtoModel Location { get; set; }

    }

    


    public class LocationDtoModel
    {
        public IEnumerable<LocationInfoDtoModel> Provincias { get; set; }
        public IEnumerable<LocationInfoDtoModel> Cantones { get; set; }
        public IEnumerable<LocationInfoDtoModel> Distritos { get; set; }
        public IEnumerable<LocationInfoDtoModel> Poblados { get; set; }
        public LocationInfoDtoModel Provincia { get; set; }
        public LocationInfoDtoModel Canton { get; set; }
        public LocationInfoDtoModel Distrito { get; set; }

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
        public string NombreCorreo { get; set; }
    }

    public class TelephoneDtoModel
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public int? IdCpsp { get; set; }
    }


    public class LocationInfoDtoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? ParentId { get; set; }
    }

    public class EstadoServicioDtoModel
    {
        public int Id { get; set; }
        public string Estado { get; set; }
    }

    public class CodPresupuestarioDtoModel
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
    }

    public class ProyectoDtoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
    }
}