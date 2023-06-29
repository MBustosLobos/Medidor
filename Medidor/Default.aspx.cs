using MedidorModel;
using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medidor
{
    public partial class Default : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
                //1. Obtener los datos del fomulario
                string nroMedidor = this.nroMedidor.Text.Trim();
                string rut = this.rutTxt.Text.Trim();



                List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();

            var medidor = new MedidorModel.DTO.Medidor()
            {
                NroMedidor = nroMedidor,
                Rut = rut,
              
            };
           
                //3. Llamar al DAL
                medidorDAL.AgregarMedidor(medidor);
                //4. Mostrar mensaje de exito
                this.mensajesLbl.Text = "Medidor Guardado Correctamente";
                Response.Redirect("VerMedidor.aspx");
            

         
        }
    }
}