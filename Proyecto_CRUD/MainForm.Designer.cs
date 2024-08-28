/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 16/08/2024
 * Hora: 9:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_CRUD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_botonNuevo;
		private System.Windows.Forms.Button btn_Agregar;
		private System.Windows.Forms.Button btn_Modificar;
		private System.Windows.Forms.Button btn_Eliminar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Producto;
		private System.Windows.Forms.TextBox txt_Producto;
		private System.Windows.Forms.Button btn_Precio;
		private System.Windows.Forms.TextBox txt_Presio;
		private System.Windows.Forms.Button btn_Descripcion;
		private System.Windows.Forms.Button btn_Salir;
		private System.Windows.Forms.TextBox txt_Descripcion;
		private System.Windows.Forms.DataGridView dgv_Productos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		
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
			this.btn_botonNuevo = new System.Windows.Forms.Button();
			this.btn_Agregar = new System.Windows.Forms.Button();
			this.btn_Modificar = new System.Windows.Forms.Button();
			this.btn_Eliminar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Producto = new System.Windows.Forms.Button();
			this.txt_Producto = new System.Windows.Forms.TextBox();
			this.btn_Precio = new System.Windows.Forms.Button();
			this.txt_Presio = new System.Windows.Forms.TextBox();
			this.btn_Descripcion = new System.Windows.Forms.Button();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.txt_Descripcion = new System.Windows.Forms.TextBox();
			this.dgv_Productos = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_botonNuevo
			// 
			this.btn_botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_botonNuevo.Location = new System.Drawing.Point(58, 92);
			this.btn_botonNuevo.Name = "btn_botonNuevo";
			this.btn_botonNuevo.Size = new System.Drawing.Size(125, 33);
			this.btn_botonNuevo.TabIndex = 0;
			this.btn_botonNuevo.Text = "NUEVO";
			this.btn_botonNuevo.UseVisualStyleBackColor = true;
			this.btn_botonNuevo.Click += new System.EventHandler(this.Btn_botonNuevoClick);
			// 
			// btn_Agregar
			// 
			this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Agregar.Location = new System.Drawing.Point(58, 156);
			this.btn_Agregar.Name = "btn_Agregar";
			this.btn_Agregar.Size = new System.Drawing.Size(125, 33);
			this.btn_Agregar.TabIndex = 1;
			this.btn_Agregar.Text = "AGREGAR";
			this.btn_Agregar.UseVisualStyleBackColor = true;
			this.btn_Agregar.Click += new System.EventHandler(this.Btn_AgregarClick);
			// 
			// btn_Modificar
			// 
			this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Modificar.Location = new System.Drawing.Point(58, 218);
			this.btn_Modificar.Name = "btn_Modificar";
			this.btn_Modificar.Size = new System.Drawing.Size(125, 33);
			this.btn_Modificar.TabIndex = 2;
			this.btn_Modificar.Text = "MODIFICAR";
			this.btn_Modificar.UseVisualStyleBackColor = true;
			this.btn_Modificar.Click += new System.EventHandler(this.Btn_ModificarClick);
			// 
			// btn_Eliminar
			// 
			this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Eliminar.Location = new System.Drawing.Point(58, 283);
			this.btn_Eliminar.Name = "btn_Eliminar";
			this.btn_Eliminar.Size = new System.Drawing.Size(125, 33);
			this.btn_Eliminar.TabIndex = 3;
			this.btn_Eliminar.Text = "ELIMINAR";
			this.btn_Eliminar.UseVisualStyleBackColor = true;
			this.btn_Eliminar.Click += new System.EventHandler(this.Btn_EliminarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(202, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 39);
			this.label1.TabIndex = 4;
			this.label1.Text = "DETALLE DE PRODUCTOS";
			// 
			// btn_Producto
			// 
			this.btn_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Producto.Location = new System.Drawing.Point(231, 91);
			this.btn_Producto.Name = "btn_Producto";
			this.btn_Producto.Size = new System.Drawing.Size(116, 33);
			this.btn_Producto.TabIndex = 5;
			this.btn_Producto.Text = "Producto:";
			this.btn_Producto.UseVisualStyleBackColor = true;
			// 
			// txt_Producto
			// 
			this.txt_Producto.Location = new System.Drawing.Point(231, 156);
			this.txt_Producto.Name = "txt_Producto";
			this.txt_Producto.Size = new System.Drawing.Size(129, 20);
			this.txt_Producto.TabIndex = 6;
			// 
			// btn_Precio
			// 
			this.btn_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Precio.Location = new System.Drawing.Point(231, 218);
			this.btn_Precio.Name = "btn_Precio";
			this.btn_Precio.Size = new System.Drawing.Size(116, 33);
			this.btn_Precio.TabIndex = 7;
			this.btn_Precio.Text = "Precio:";
			this.btn_Precio.UseVisualStyleBackColor = true;
			// 
			// txt_Presio
			// 
			this.txt_Presio.Location = new System.Drawing.Point(231, 291);
			this.txt_Presio.Name = "txt_Presio";
			this.txt_Presio.Size = new System.Drawing.Size(129, 20);
			this.txt_Presio.TabIndex = 8;
			// 
			// btn_Descripcion
			// 
			this.btn_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Descripcion.Location = new System.Drawing.Point(415, 91);
			this.btn_Descripcion.Name = "btn_Descripcion";
			this.btn_Descripcion.Size = new System.Drawing.Size(140, 33);
			this.btn_Descripcion.TabIndex = 9;
			this.btn_Descripcion.Text = "Descripcion:";
			this.btn_Descripcion.UseVisualStyleBackColor = true;
			// 
			// btn_Salir
			// 
			this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Salir.Location = new System.Drawing.Point(58, 545);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(125, 33);
			this.btn_Salir.TabIndex = 10;
			this.btn_Salir.Text = "SALIR";
			this.btn_Salir.UseVisualStyleBackColor = true;
			this.btn_Salir.Click += new System.EventHandler(this.Btn_SalirClick);
			// 
			// txt_Descripcion
			// 
			this.txt_Descripcion.Location = new System.Drawing.Point(415, 137);
			this.txt_Descripcion.Multiline = true;
			this.txt_Descripcion.Name = "txt_Descripcion";
			this.txt_Descripcion.Size = new System.Drawing.Size(255, 174);
			this.txt_Descripcion.TabIndex = 11;
			// 
			// dgv_Productos
			// 
			this.dgv_Productos.BackgroundColor = System.Drawing.SystemColors.Highlight;
			this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Codigo,
			this.Producto,
			this.Precio,
			this.Descripcion});
			this.dgv_Productos.Location = new System.Drawing.Point(202, 336);
			this.dgv_Productos.Name = "dgv_Productos";
			this.dgv_Productos.Size = new System.Drawing.Size(447, 242);
			this.dgv_Productos.TabIndex = 12;
			this.dgv_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProductosCellContentClick);
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "CODIGO";
			this.Codigo.Name = "Codigo";
			// 
			// Producto
			// 
			this.Producto.HeaderText = "PRODUCTO";
			this.Producto.Name = "Producto";
			// 
			// Precio
			// 
			this.Precio.HeaderText = "PRECIO";
			this.Precio.Name = "Precio";
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "DESCRIPCION";
			this.Descripcion.Name = "Descripcion";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 619);
			this.Controls.Add(this.dgv_Productos);
			this.Controls.Add(this.txt_Descripcion);
			this.Controls.Add(this.btn_Salir);
			this.Controls.Add(this.btn_Descripcion);
			this.Controls.Add(this.txt_Presio);
			this.Controls.Add(this.btn_Precio);
			this.Controls.Add(this.txt_Producto);
			this.Controls.Add(this.btn_Producto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Eliminar);
			this.Controls.Add(this.btn_Modificar);
			this.Controls.Add(this.btn_Agregar);
			this.Controls.Add(this.btn_botonNuevo);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CRUD";
			((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
