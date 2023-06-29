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
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void Eliminar(string rut)
        {
            
                Medidor eliminando = medidores.Find(c => c.Rut == rut);
                medidores.Remove(eliminando);
            
        }

        public List<Medidor> ObtenerMedidor()
        {
            return medidores;
        }
    }
}
