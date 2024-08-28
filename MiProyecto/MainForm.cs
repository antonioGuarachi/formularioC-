/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 23/08/2024
 * Hora: 9:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiProyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		  public void limpiar()
        {
            txt_nombreCompleto.Clear();
            txt_ci.Clear();
          
        }
		
		  int i=1;
		void Btn_agregarClick(object sender, EventArgs e)
		{
			string nom = txt_nombreCompleto.Text;
			string ci = txt_ci.Text;
			string exp=cbbx_expedido.Text;
			DateTime fechanac = dtp_fechanacimiento.Value;
			string ge;
			string doc;
			if(rbt_masculino.Checked)
				ge="Masculino";
			else 
				ge="Femenino";
			if(cbx_documentos.Checked)
				doc="completo";
			else
				doc="incompleto";
			
			
			dgv_formulario.Rows.Add(i+"",nom,ci,exp,ge,doc);
			i++;
            limpiar();
            numeros();
		}
		void Btn_nuevoClick(object sender, EventArgs e)
		{
            btn_nuevo.Enabled = true;
            txt_nombreCompleto.Focus();
		}
		
		int fila;
		void Dgv_formularioCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fila = dgv_formulario.CurrentRow.Index;
            
			txt_nombreCompleto.Text=dgv_formulario[1,fila].Value.ToString();
				txt_ci.Text=dgv_formulario[2,fila].Value.ToString();
			
           // btn_agregar.Enabled = false;
            txt_nombreCompleto.Focus(); 
           
		}
		void Btn_modificarClick(object sender, EventArgs e)
		{
	         	string nom = txt_nombreCompleto.Text;
			string ci = txt_ci.Text;
			string exp=cbbx_expedido.Text;
			DateTime fechanac = dtp_fechanacimiento.Value;
			string ge;
			string doc;
			if(rbt_masculino.Checked)
				ge="Masculino";
			else 
				ge="Femenino";
			if(cbx_documentos.Checked)
				doc="completo";
			else
				doc="incompleto";
			
			dgv_formulario[1,fila].Value=nom;
			dgv_formulario[2,fila].Value=ci;
			dgv_formulario[3,fila].Value=exp;
			dgv_formulario[4,fila].Value=fechanac;
			dgv_formulario[5,fila].Value=ge;
			dgv_formulario[6,fila].Value=exp;
			dgv_formulario[7,fila].Value=doc;
			
			nom=dgv_formulario[1,fila].Value.ToString();
			ci=dgv_formulario[2,fila].Value.ToString();
			
		}
		void Btn_eliminarClick(object sender, EventArgs e)
		{
			dgv_formulario.Rows.RemoveAt(fila);
			numeros();
		}
		void numeros(){
			fila=0;
			for (int i = 1; i < dgv_formulario.Rows.Count; i++) {
				dgv_formulario[0,fila].Value=i;
				fila++;
			}
			limpiar();
		}
	}
}
