
namespace QuarkIngreso.View
{
    partial class Vendedores
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
            this.nuevoVendedor = new System.Windows.Forms.Button();
            this.tablaVendedores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoVendedor
            // 
            this.nuevoVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(43)))), ((int)(((byte)(174)))));
            this.nuevoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoVendedor.ForeColor = System.Drawing.Color.White;
            this.nuevoVendedor.Location = new System.Drawing.Point(12, 275);
            this.nuevoVendedor.Name = "nuevoVendedor";
            this.nuevoVendedor.Size = new System.Drawing.Size(342, 39);
            this.nuevoVendedor.TabIndex = 5;
            this.nuevoVendedor.Text = "Agregar nueva vendedor";
            this.nuevoVendedor.UseVisualStyleBackColor = false;
            this.nuevoVendedor.Click += new System.EventHandler(this.nuevoVendedor_Click);
            // 
            // tablaVendedores
            // 
            this.tablaVendedores.AllowUserToAddRows = false;
            this.tablaVendedores.AllowUserToDeleteRows = false;
            this.tablaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido});
            this.tablaVendedores.Location = new System.Drawing.Point(12, 12);
            this.tablaVendedores.Name = "tablaVendedores";
            this.tablaVendedores.ReadOnly = true;
            this.tablaVendedores.Size = new System.Drawing.Size(342, 257);
            this.tablaVendedores.TabIndex = 4;
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
            // apellido
            // 
            this.apellido.Frozen = true;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(363, 324);
            this.Controls.Add(this.nuevoVendedor);
            this.Controls.Add(this.tablaVendedores);
            this.Name = "Vendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.Vendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nuevoVendedor;
        private System.Windows.Forms.DataGridView tablaVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}