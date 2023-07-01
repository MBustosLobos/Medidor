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
    public partial class VerMedidor : System.Web.UI.Page
    {
        public partial class VerClientes : System.Web.UI.Page
        {
            private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    cargagrilla();
                }
            }

            protected void cargagrilla()
            {
                List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();

            }
        }
    }
}