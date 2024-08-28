﻿/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 23/08/2024
 * Hora: 9:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_CRUD
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_ingresar;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_error;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_error = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(119, 320);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(119, 388);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña:";
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ingresar.Location = new System.Drawing.Point(285, 484);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(133, 41);
			this.btn_ingresar.TabIndex = 2;
			this.btn_ingresar.Text = "Ingresar";
			this.btn_ingresar.UseVisualStyleBackColor = true;
			this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresarClick);
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(285, 325);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(222, 20);
			this.txt_usuario.TabIndex = 3;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(285, 393);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.Size = new System.Drawing.Size(222, 20);
			this.txt_contraseña.TabIndex = 4;
			this.txt_contraseña.UseSystemPasswordChar = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(309, 86);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 160);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(323, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Iniciar Sesion";
			// 
			// lbl_error
			// 
			this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_error.ForeColor = System.Drawing.Color.Red;
			this.lbl_error.Location = new System.Drawing.Point(169, 558);
			this.lbl_error.Name = "lbl_error";
			this.lbl_error.Size = new System.Drawing.Size(423, 62);
			this.lbl_error.TabIndex = 7;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 715);
			this.Controls.Add(this.lbl_error);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.btn_ingresar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}