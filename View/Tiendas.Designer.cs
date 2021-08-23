
namespace QuarkIngreso.View
{
    partial class Tiendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaTiendas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuevaTienda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaTiendas
            // 
            this.tablaTiendas.AllowUserToAddRows = false;
            this.tablaTiendas.AllowUserToDeleteRows = false;
            this.tablaTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.direccion,
            this.vendedor});
            this.tablaTiendas.Location = new System.Drawing.Point(7, 21);
            this.tablaTiendas.Name = "tablaTiendas";
            this.tablaTiendas.ReadOnly = true;
            this.tablaTiendas.Size = new System.Drawing.Size(444, 257);
            this.tablaTiendas.TabIndex = 2;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.Frozen = true;
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // vendedor
            // 
            this.vendedor.Frozen = true;
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            // 
            // nuevaTienda
            // 
            this.nuevaTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(43)))), ((int)(((byte)(174)))));
            this.nuevaTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaTienda.ForeColor = System.Drawing.Color.White;
            this.nuevaTienda.Location = new System.Drawing.Point(7, 284);
            this.nuevaTienda.Name = "nuevaTienda";
            this.nuevaTienda.Size = new System.Drawing.Size(444, 39);
            this.nuevaTienda.TabIndex = 3;
            this.nuevaTienda.Text = "Agregar nueva tienda";
            this.nuevaTienda.UseVisualStyleBackColor = false;
            this.nuevaTienda.Click += new System.EventHandler(this.nuevaTienda_Click);
            // 
            // Tiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(456, 328);
            this.Controls.Add(this.nuevaTienda);
            this.Controls.Add(this.tablaTiendas);
            this.Name = "Tiendas";
            this.Text = "Tiendas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaTiendas;
        private System.Windows.Forms.Button nuevaTienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
    }
}