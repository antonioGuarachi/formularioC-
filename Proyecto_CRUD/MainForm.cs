/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 16/08/2024
 * Hora: 9:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_CRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Btn_SalirClick(object sender, EventArgs e)
        {
            Close();
        }

        void Btn_botonNuevoClick(object sender, EventArgs e)
        {
            limpiar();
            btn_Agregar.Enabled = true;
            txt_Producto.Focus();
        }

        public void limpiar()
        {
            txt_Producto.Clear();
            txt_Presio.Clear();
            txt_Descripcion.Clear();
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }

        void Btn_AgregarClick(object sender, EventArgs e)
        {
            string producto = txt_Producto.Text;
            string precio = txt_Presio.Text;
            string des = txt_Descripcion.Text;

            dgv_Productos.Rows.Add(dgv_Productos.Rows.Count + 1, producto, precio, des);
            limpiar();
        }

        void Btn_ModificarClick(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                string prod = txt_Producto.Text;
                string pre = txt_Presio.Text;
                string des = txt_Descripcion.Text;

                dgv_Productos[1, fila].Value = prod;
                dgv_Productos[2, fila].Value = pre;
                dgv_Productos[3, fila].Value = des;

                limpiar();
                txt_Producto.Focus();
            }
        }

        int fila;
        void Dgv_ProductosCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgv_Productos.CurrentRow.Index;
            txt_Producto.Text = dgv_Productos[1, fila].Value.ToString();
            txt_Presio.Text = dgv_Productos[2, fila].Value.ToString();
            txt_Descripcion.Text = dgv_Productos[3, fila].Value.ToString();

            btn_Modificar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Agregar.Enabled = false;
            txt_Producto.Focus(); 
        }

        void Btn_EliminarClick(object sender, EventArgs e)
        {
                dgv_Productos.Rows.RemoveAt(fila);
                
                  fila=0;
            	for(int i=1;i<dgv_Productos.Rows.Count;i++){
            	dgv_Productos[0,fila].Value=i;
            	fila++;
            } 
                  limpiar();
        }
    }
}

// CRUD 
		// Create, Read, Update, Delete (crear, modificar y eliminar)