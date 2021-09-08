using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    class CPedido
    {
        private string nro;
        private string obs;
        private string cliente;
        private bool estado;

        public string Nro { get => nro; set => nro = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
