﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO

{
    public class Medidor
    {
        private string rut;
        private string nroMedidor;
        private string consumo;
        private Lectura mLectura;


        public string Rut { get => rut; set => rut = value; }
        public string NroMedidor { get => nroMedidor; set => nroMedidor = value; }
        public string Consumo { get => consumo; set => consumo = value; }
        public Lectura MLectura { get => mLectura; set => mLectura = value; }
    }
}
