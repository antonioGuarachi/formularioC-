/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 23/08/2024
 * Hora: 9:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MiProyecto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_nombreCompleto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_ci;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbbx_expedido;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rbt_masculino;
		private System.Windows.Forms.RadioButton rbt_femenino;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbbx_estadoCivil;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox cbx_documentos;
		private System.Windows.Forms.Button btn_nuevo;
		private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.Button btn_modificar;
		private System.Windows.Forms.Button btn_eliminar;
		private System.Windows.Forms.DataGridView dgv_formulario;
		private System.Windows.Forms.DataGridViewTextBoxColumn fff;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DateTimePicker dtp_fechanacimiento;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt_nombreCompleto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_ci = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbbx_expedido = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.rbt_masculino = new System.Windows.Forms.RadioButton();
			this.rbt_femenino = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.cbbx_estadoCivil = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbx_documentos = new System.Windows.Forms.CheckBox();
			this.btn_nuevo = new System.Windows.Forms.Button();
			this.btn_agregar = new System.Windows.Forms.Button();
			this.btn_modificar = new System.Windows.Forms.Button();
			this.btn_eliminar = new System.Windows.Forms.Button();
			this.dgv_formulario = new System.Windows.Forms.DataGridView();
			this.dtp_fechanacimiento = new System.Windows.Forms.DateTimePicker();
			this.fff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_formulario)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nombre Completo:";
			// 
			// txt_nombreCompleto
			// 
			this.txt_nombreCompleto.Location = new System.Drawing.Point(255, 82);
			this.txt_nombreCompleto.Name = "txt_nombreCompleto";
			this.txt_nombreCompleto.Size = new System.Drawing.Size(249, 20);
			this.txt_nombreCompleto.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(281, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 39);
			this.label1.TabIndex = 14;
			this.label1.Text = "Registro de Estudiante";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(161, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "C.I.:";
			// 
			// txt_ci
			// 
			this.txt_ci.Location = new System.Drawing.Point(255, 126);
			this.txt_ci.Name = "txt_ci";
			this.txt_ci.Size = new System.Drawing.Size(249, 20);
			this.txt_ci.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(532, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Expedido:";
			// 
			// cbbx_expedido
			// 
			this.cbbx_expedido.FormattingEnabled = true;
			this.cbbx_expedido.Items.AddRange(new object[] {
			"La Paz ",
			"Cochabamba",
			"Santa Cruz",
			"Oruro",
			"Chuquisaca ",
			"Pando",
			"Beni ",
			"Tarija",
			"Potosi"});
			this.cbbx_expedido.Location = new System.Drawing.Point(639, 125);
			this.cbbx_expedido.Name = "cbbx_expedido";
			this.cbbx_expedido.Size = new System.Drawing.Size(121, 21);
			this.cbbx_expedido.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(166, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "Fecha de Nacimiento:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(134, 267);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "Genero:";
			// 
			// rbt_masculino
			// 
			this.rbt_masculino.Location = new System.Drawing.Point(255, 267);
			this.rbt_masculino.Name = "rbt_masculino";
			this.rbt_masculino.Size = new System.Drawing.Size(104, 24);
			this.rbt_masculino.TabIndex = 24;
			this.rbt_masculino.TabStop = true;
			this.rbt_masculino.Text = "Masculino";
			this.rbt_masculino.UseVisualStyleBackColor = true;
			// 
			// rbt_femenino
			// 
			this.rbt_femenino.Location = new System.Drawing.Point(255, 297);
			this.rbt_femenino.Name = "rbt_femenino";
			this.rbt_femenino.Size = new System.Drawing.Size(104, 24);
			this.rbt_femenino.TabIndex = 25;
			this.rbt_femenino.TabStop = true;
			this.rbt_femenino.Text = "Femenino";
			this.rbt_femenino.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(112, 351);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 23);
			this.label7.TabIndex = 26;
			this.label7.Text = "Estado Civil:";
			// 
			// cbbx_estadoCivil
			// 
			this.cbbx_estadoCivil.FormattingEnabled = true;
			this.cbbx_estadoCivil.Items.AddRange(new object[] {
			"Soltero",
			"Casado"});
			this.cbbx_estadoCivil.Location = new System.Drawing.Point(238, 351);
			this.cbbx_estadoCivil.Name = "cbbx_estadoCivil";
			this.cbbx_estadoCivil.Size = new System.Drawing.Size(121, 21);
			this.cbbx_estadoCivil.TabIndex = 27;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(112, 440);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(166, 23);
			this.label8.TabIndex = 28;
			this.label8.Text = "Documentos:";
			// 
			// cbx_documentos
			// 
			this.cbx_documentos.Location = new System.Drawing.Point(238, 467);
			this.cbx_documentos.Name = "cbx_documentos";
			this.cbx_documentos.Size = new System.Drawing.Size(104, 24);
			this.cbx_documentos.TabIndex = 29;
			this.cbx_documentos.Text = "Completo";
			this.cbx_documentos.UseVisualStyleBackColor = true;
			// 
			// btn_nuevo
			// 
			this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_nuevo.Location = new System.Drawing.Point(549, 351);
			this.btn_nuevo.Name = "btn_nuevo";
			this.btn_nuevo.Size = new System.Drawing.Size(110, 34);
			this.btn_nuevo.TabIndex = 30;
			this.btn_nuevo.Text = "Nuevo";
			this.btn_nuevo.UseVisualStyleBackColor = true;
			this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevoClick);
			// 
			// btn_agregar
			// 
			this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_agregar.Location = new System.Drawing.Point(549, 391);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(110, 34);
			this.btn_agregar.TabIndex = 31;
			this.btn_agregar.Text = "Agregar";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.Btn_agregarClick);
			// 
			// btn_modificar
			// 
			this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_modificar.Location = new System.Drawing.Point(549, 431);
			this.btn_modificar.Name = "btn_modificar";
			this.btn_modificar.Size = new System.Drawing.Size(110, 34);
			this.btn_modificar.TabIndex = 32;
			this.btn_modificar.Text = "Modificar";
			this.btn_modificar.UseVisualStyleBackColor = true;
			this.btn_modificar.Click += new System.EventHandler(this.Btn_modificarClick);
			// 
			// btn_eliminar
			// 
			this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_eliminar.Location = new System.Drawing.Point(549, 471);
			this.btn_eliminar.Name = "btn_eliminar";
			this.btn_eliminar.Size = new System.Drawing.Size(110, 34);
			this.btn_eliminar.TabIndex = 33;
			this.btn_eliminar.Text = "Eliminar";
			this.btn_eliminar.UseVisualStyleBackColor = true;
			this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminarClick);
			// 
			// dgv_formulario
			// 
			this.dgv_formulario.BackgroundColor = System.Drawing.SystemColors.Highlight;
			this.dgv_formulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_formulario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.fff,
			this.Nombre,
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4});
			this.dgv_formulario.Location = new System.Drawing.Point(77, 520);
			this.dgv_formulario.Name = "dgv_formulario";
			this.dgv_formulario.Size = new System.Drawing.Size(642, 156);
			this.dgv_formulario.TabIndex = 34;
			this.dgv_formulario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_formularioCellContentClick);
			// 
			// dtp_fechanacimiento
			// 
			this.dtp_fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fechanacimiento.Location = new System.Drawing.Point(258, 193);
			this.dtp_fechanacimiento.Name = "dtp_fechanacimiento";
			this.dtp_fechanacimiento.Size = new System.Drawing.Size(101, 20);
			this.dtp_fechanacimiento.TabIndex = 35;
			// 
			// fff
			// 
			this.fff.HeaderText = "Nro.";
			this.fff.Name = "fff";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "C.I.";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Expedido";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Genero";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Documentos";
			this.Column4.Name = "Column4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 698);
			this.Controls.Add(this.dtp_fechanacimiento);
			this.Controls.Add(this.dgv_formulario);
			this.Controls.Add(this.btn_eliminar);
			this.Controls.Add(this.btn_modificar);
			this.Controls.Add(this.btn_agregar);
			this.Controls.Add(this.btn_nuevo);
			this.Controls.Add(this.cbx_documentos);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbbx_estadoCivil);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.rbt_femenino);
			this.Controls.Add(this.rbt_masculino);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbbx_expedido);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_ci);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_nombreCompleto);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MiProyecto";
			((System.ComponentModel.ISupportInitialize)(this.dgv_formulario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
