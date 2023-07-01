using System;
using System.Collections.Generic;
using MedidorModel.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<TipoMedidor> medidores = new List<TipoMedidor>();
        public void AgregarMedidor(TipoMedidor tipomedidor)
        {
            medidores.Add(tipomedidor);
        }      

        public void Eliminar(string rut)
        {

            TipoMedidor eliminando = medidores.Find(c => c.Rut == rut);
                medidores.Remove(eliminando);
            
        }

        public List<TipoMedidor> ObtenerMedidor()
        {
            return new List<TipoMedidor>()
            {
                new TipoMedidor()
                {
                    Tipo = "Monofásico estático"

                },
                new TipoMedidor()
                {
                    Tipo = "Bifásico Estático"
                },
                 new TipoMedidor()
                {
                    Tipo = "Trifásico Estático"
                },
                  new TipoMedidor()
                {
                    Tipo = "Trifásico Estático de energía activa"
                },
                   new TipoMedidor()
                {
                    Tipo = "Trifásico Estático con perfil de carga"
                },
                    new TipoMedidor()
                {
                    Tipo=   "Multifuncional de energía"
                },

            };
        }

     
    }
}
