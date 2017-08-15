using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EncuestasC.Models
{
    public class GeographicDtoModel
    {
        public Int32 Id { get; set; }
        public IEnumerable<Provinciax> Provincias { get; set; }
        public string Canton { get; set; }
        public SelectList ProvinciaList { get; set; }

    }
}