using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRRHH.Modelos
{
    internal class EmpleadoFila
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }

        // Permite mostrar la burbuja verde o roja
        public CellTag Estado { get; set; }

        // Permite mostrar varios botones en una celda
        public ICell[] Acciones { get; set; }
    }
}
