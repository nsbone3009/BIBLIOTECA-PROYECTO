using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    class csAjustarDataGridView
    {
        public void Ajustar(DataGridView contenedor)
        {
            for (int i = 0; i < contenedor.ColumnCount; i++)
            {
                contenedor.Columns[i].Width = contenedor.Width / contenedor.ColumnCount;
                contenedor.Columns[i].Resizable = DataGridViewTriState.False;
            }
        }
    }
}
