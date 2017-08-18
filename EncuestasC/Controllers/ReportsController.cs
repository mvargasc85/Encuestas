using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using System.IO;
using EncuestasC.Models;

namespace EncuestasC.Controllers
{
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/
        private readonly EncuestasEntitiesx _entities = new EncuestasEntitiesx();

        public ActionResult EncuestasRP(string id)
        {
               
        LocalReport lr = new LocalReport();
        string path = Path.Combine(Server.MapPath("~/reports"), "RPEncuestas.rdlc");
        if (System.IO.File.Exists(path))
        {
            lr.ReportPath = path;
        }
        else
        {
            return View("Index");
        }
        List<Cantonx> cm = new List<Cantonx>();
        using (EncuestasEntitiesx dc = new EncuestasEntitiesx())
        {
            cm = dc.Canton.ToList();
        }
        ReportDataSource rd = new ReportDataSource("EncuestasDataSet1", cm);
        lr.DataSources.Add(rd);
        string reportType = id;
        string mimeType;
        string encoding;
        string fileNameExtension;
     
     
     
        string deviceInfo =
     
        "<DeviceInfo>" +
        "  <OutputFormat>" + id + "</OutputFormat>" +
        "  <PageWidth>8.5in</PageWidth>" +
        "  <PageHeight>11in</PageHeight>" +
        "  <MarginTop>0.5in</MarginTop>" +
        "  <MarginLeft>1in</MarginLeft>" +
        "  <MarginRight>1in</MarginRight>" +
        "  <MarginBottom>0.5in</MarginBottom>" +
        "</DeviceInfo>";
     
        Warning[] warnings;
        string[] streams;
        byte[] renderedBytes;
     
        renderedBytes = lr.Render(
            reportType,
            deviceInfo,
            out mimeType,
            out encoding,
            out fileNameExtension,
            out streams,
            out warnings);
        return File(renderedBytes, mimeType);
    }
        }

    }

