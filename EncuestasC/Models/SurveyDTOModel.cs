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
        public IEnumerable<Telefonox> Telefonos { get; set; }
        public IEnumerable<Emailx> Emails { get; set; }
        public EstadoServiciox EstadoServicio { get; set; }
        public string Comentarios { get; set; }
        public string NombreContacto { get; set; }
        public char Contesta { get; set; }
        public SelectList CpspList { get; set; }

    }
}