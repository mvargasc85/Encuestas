using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;

namespace EncuestasC.reports
{
    public partial class ReporteEncuesta : System.Web.UI.Page
   {
    protected void Page_Load(object sender, EventArgs e)
    {
        var conn = new SqlConnection("Data Source=ANDRES-PC;Integrated Security=True;User Instance=True");
        try
        {
            using (var comando = new SqlCommand("SELECT * FROM dbo.Encuesta", conn))
            {
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    var ds = new DataSet();
                    adaptador.Fill(ds);
 
                    var reporte = new ReportDocument();
                    reporte.Load(Server.MapPath("reports/RPEncuestas.rpt"));
                    reporte.SetDataSource(ds.Tables[0]);
                    reporte.DataSourceConnections[0].SetConnection("ANDRES-PC", "Encuestas", "Integrated Security=True", "");
 
                    VisorCR.ReportSource = reporte;
                } // end using adaptador
            } // end using comando
        } // end try
        catch (Exception ex)
        {
            lblMensaje.Text = ex.Message;
        }
        finally
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.Dispose();
        }
    }
}}