﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmListaUsuariosAcceso : Form
    {
        static frmListaUsuariosAcceso instancia = null;
        public static frmListaUsuariosAcceso Validacion()
        {
            if (instancia == null)
                instancia = new frmListaUsuariosAcceso();
            return instancia;
        }
        public frmListaUsuariosAcceso()
        {
            InitializeComponent();
        }
    }
}
