using System;
using System.Collections.Generic;
using MedidorModel.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IMedidorDAL
    {
        List<TipoMedidor> ObtenerMedidor();
        void AgregarMedidor(TipoMedidor medidor);
        
     //Eliminar
        void Eliminar(string rut);
    }

}
