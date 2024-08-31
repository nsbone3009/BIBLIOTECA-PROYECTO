using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    class csLLenarDataGridView
    {
        public DataGridView Mostrar(DataGridView Tabla, string consulta)
        {
            int f = 0; //Contador.
            csConexionSQL dataBase = new csConexionSQL(); //Intancia un Objeto.
            DataTable Contenedor = new DataTable(); //Crea una tabla en memoria.
            Contenedor = dataBase.Registros(consulta); //Asigna los Datos al contenedor.

            foreach (DataRow row in Contenedor.Rows) //Recorrera fila por fila del contenedor.
            {
                Tabla.Rows.Add(row.ItemArray); //ItemArray obtiene todos los valores de las celdas en forma de un Array, luego se añade una fila con estos valores.
                Tabla.Rows[f++].Height = 41; //Establece el alto de fila.
            }
            for (int i = 0; i < Tabla.ColumnCount - 2; i++)
            {
                Tabla.Columns[i].Width = Tabla.Width / Tabla.ColumnCount - 1;
                Tabla.Columns[i].Resizable = DataGridViewTriState.False;
            }
            return Tabla;
        }
    }
}
