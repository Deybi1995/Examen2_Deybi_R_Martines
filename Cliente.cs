using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_Deybi_R_Martines
{
    public class Cliente
    {

        //Propiedades
        public String Identidad { get; set; }
        public String Tipo_de_Cliente { get; set; }
        public String Estado { get; set; }
        public int Tickes { get; set; }
        public int Costo { get; set; }
        public String Nombre_cliente { get; set; }
        public String Direccion { get; set; }
        public int Costo_Total_Ticks { get; set; }

        //Constructores
        public Cliente()
        {

        }

        public Cliente(string No_Identidad, string Tipo_Cliente, string Estado_Ticks, int No_Ticks, int Costo_Ticks, string Cliente, string Direccion_Cliente, int Total)
        {
            Identidad = No_Identidad;
            Tipo_de_Cliente = Tipo_Cliente;
            Estado = Estado_Ticks;
            Tickes = No_Ticks;
            Costo = Costo_Ticks;
            Nombre_cliente = Cliente;
            Direccion = Direccion_Cliente;
            Costo_Total_Ticks = Total;
        }

    }
}
