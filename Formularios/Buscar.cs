﻿using ManaCar.Clases;
using ManaCar.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaCar
{
    public partial class Buscar : Form
    {
        
        Conexion con = new Conexion();
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<DatosClientes> auxiliar = new List<DatosClientes>();

            for(int i = 0; i< con.MostrarCliente(tbBuscarDNI.Text).Count; i++)
            {
                DatosClientes dc = con.MostrarCliente(tbBuscarDNI.Text)[i];
                auxiliar.Add(dc);
                lbUsuarios.Items.AddRange(auxiliar.ToArray());
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DatosClientes dc = (DatosClientes)lbUsuarios.SelectedItem;
            if( dc!= null){
                DatosEncontrados de = new DatosEncontrados();
               
                de.setDcData(dc);
                de.ShowDialog();
                this.Close();
            }
            
        }

       
    }
}