using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaDeProductos
{
    public partial class Form1 : Form
    {
        string[,] productos = new string[10, 2];
        decimal[] precios = new decimal[10];

        int fila = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //string[,] productos = new string[10, 2];
            //productos[0, 0] = txtCodigo.Text;
            //productos[0, 1] = txtProducto.Text;

            productos[fila, 0] = txtCodigo.Text;
            productos[fila, 1] = txtProducto.Text;

            precios[fila] = Convert.ToDecimal(txtPrecio.Text);

            fila = fila + 1;
            Listar();
        }

        private void Listar()
        {
            lblResultado.Text = "";

            for (int i = 0; i < fila; i++)
            {
                lblResultado.Text = lblResultado.Text
                    + productos[i,0]
                    + " - "
                    + productos[i, 1]
                    + " - "
                    + precios[i].ToString()
                    + "\r\n";
            }
        }
    }
}
