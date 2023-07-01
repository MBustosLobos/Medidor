using MedidorModel;
using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
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
            if (!IsPostBack)
            {
                List<TipoMedidor> medidors = medidorDAL.ObtenerMedidor();
                this.medidorDbl.DataSource = medidors;
                this.medidorDbl.DataTextField = "Tipo";
                this.medidorDbl.DataBind();
            }




        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
                //1. Obtener los datos del fomulario
                string nroMedidor = this.nroMedidor.Text.Trim();
                string rut = this.lecturaTxt.Text.Trim();

              //DropDown
                string tipoMedidortxt = this.medidorDbl.SelectedItem.Text;
                //objeto TipoMedidor
                 List<TipoMedidor> medidors = medidorDAL.ObtenerMedidor();
                 TipoMedidor medidores = medidors.Find(b => b.Tipo == this.medidorDbl.SelectedItem.Value);


               List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();




                 TipoMedidor medidorObj = new TipoMedidor()
                 {               
                    NroMedidor = nroMedidor,
                    Tipo= tipoMedidortxt
                 };
                
            // mensaje de éxito
                this.mensajesLbl.Text = "Medidor Guardado Correctamente";
                Response.Redirect("VerMedidor.aspx");
            

         
        }
    }
}