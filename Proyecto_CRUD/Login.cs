/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 23/08/2024
 * Hora: 9:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_CRUD
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		
		void Btn_ingresarClick(object sender, EventArgs e)
		{
			string usu,con;
			usu = txt_usuario.Text;
			con = txt_contraseña.Text;
			if(usu.Equals("Marcos") && con.Equals("12345")){
				MessageBox.Show("Bienvenido "+usu);
				MainForm MG = new MainForm();
				this.Hide();
				MG.ShowDialog();
				this.Show();
				lbl_error.Text = "";
			}
			else{
				lbl_error.Text = "Error.... usuario o contraseña inexistente";
			}
			
			txt_usuario.Clear();
			txt_contraseña.Clear();
			txt_usuario.Focus();
			
		}
	}
}
