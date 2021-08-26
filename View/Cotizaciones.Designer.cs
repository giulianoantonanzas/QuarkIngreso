
namespace QuarkIngreso.View
{
    partial class Cotizaciones
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
            this.generarCotizacion = new System.Windows.Forms.Button();
            this.tablaCotizacion = new System.Windows.Forms.DataGridView();
            this.tienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // generarCotizacion
            // 
            this.generarCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(43)))), ((int)(((byte)(174)))));
            this.generarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarCotizacion.ForeColor = System.Drawing.Color.White;
            this.generarCotizacion.Location = new System.Drawing.Point(4, 334);
            this.generarCotizacion.Name = "generarCotizacion";
            this.generarCotizacion.Size = new System.Drawing.Size(894, 39);
            this.generarCotizacion.TabIndex = 0;
            this.generarCotizacion.Text = "Generar nueva cotización";
            this.generarCotizacion.UseVisualStyleBackColor = false;
            this.generarCotizacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaCotizacion
            // 
            this.tablaCotizacion.AllowUserToAddRows = false;
            this.tablaCotizacion.AllowUserToDeleteRows = false;
            this.tablaCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tienda,
            this.prenda,
            this.detalles,
            this.calidad,
            this.stock,
            this.precioUnidad,
            this.total});
            this.tablaCotizacion.Location = new System.Drawing.Point(4, 16);
            this.tablaCotizacion.Name = "tablaCotizacion";
            this.tablaCotizacion.ReadOnly = true;
            this.tablaCotizacion.Size = new System.Drawing.Size(894, 312);
            this.tablaCotizacion.TabIndex = 1;
            // 
            // tienda
            // 
            this.tienda.FillWeight = 150F;
            this.tienda.Frozen = true;
            this.tienda.HeaderText = "Tienda";
            this.tienda.Name = "tienda";
            this.tienda.ReadOnly = true;
            this.tienda.Width = 150;
            // 
            // prenda
            // 
            this.prenda.Frozen = true;
            this.prenda.HeaderText = "Prenda";
            this.prenda.Name = "prenda";
            this.prenda.ReadOnly = true;
            // 
            // detalles
            // 
            this.detalles.FillWeight = 200F;
            this.detalles.Frozen = true;
            this.detalles.HeaderText = "Detalles";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Width = 200;
            // 
            // calidad
            // 
            this.calidad.Frozen = true;
            this.calidad.HeaderText = "Calidad";
            this.calidad.Name = "calidad";
            this.calidad.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.Frozen = true;
            this.stock.HeaderText = "Unidad de stock disponible";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // precioUnidad
            // 
            this.precioUnidad.Frozen = true;
            this.precioUnidad.HeaderText = "Precio por unidad";
            this.precioUnidad.Name = "precioUnidad";
            this.precioUnidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 379);
            this.Controls.Add(this.tablaCotizacion);
            this.Controls.Add(this.generarCotizacion);
            this.Name = "Cotizaciones";
            this.Text = "Registro de Cotizaciones";
            this.Load += new System.EventHandler(this.Cotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCotizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarCotizacion;
        private System.Windows.Forms.DataGridView tablaCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn calidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}