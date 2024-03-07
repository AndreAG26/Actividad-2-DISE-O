using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.MODELO
{
    internal abstract class Maquinaria
    {
        protected double valor;
        protected int vidaUtil;
        protected String marca;
        protected String descricion;

       public Maquinaria(double valor, int vidaUtil, string marca, string descricion)
        {
            this.valor = valor;
            this.vidaUtil = vidaUtil;
            this.marca = marca;
            this.descricion = descricion;
        }

        public abstract String calcularDepreciacion();
    }
}
