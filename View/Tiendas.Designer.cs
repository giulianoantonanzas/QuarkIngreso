
using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            this.nuevaTienda = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tablaTiendas.Location = new System.Drawing.Point(7, 12);
            this.tablaTiendas.Name = "tablaTiendas";
            this.tablaTiendas.ReadOnly = true;
            this.tablaTiendas.Size = new System.Drawing.Size(576, 266);
            this.tablaTiendas.TabIndex = 2;
            // 
            // nuevaTienda
            // 
            this.nuevaTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(43)))), ((int)(((byte)(174)))));
            this.nuevaTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaTienda.ForeColor = System.Drawing.Color.White;
            this.nuevaTienda.Location = new System.Drawing.Point(7, 284);
            this.nuevaTienda.Name = "nuevaTienda";
            this.nuevaTienda.Size = new System.Drawing.Size(576, 39);
            this.nuevaTienda.TabIndex = 3;
            this.nuevaTienda.Text = "Agregar nueva tienda";
            this.nuevaTienda.UseVisualStyleBackColor = false;
            this.nuevaTienda.Click += new System.EventHandler(this.nuevaTienda_Click);
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
            this.nombre.FillWeight = 120F;
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // direccion
            // 
            this.direccion.FillWeight = 120F;
            this.direccion.Frozen = true;
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 120;
            // 
            // vendedor
            // 
            this.vendedor.FillWeight = 200F;
            this.vendedor.Frozen = true;
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 200;
            // 
            // Tiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(587, 328);
            this.Controls.Add(this.nuevaTienda);
            this.Controls.Add(this.tablaTiendas);
            this.Name = "Tiendas";
            this.Text = "Tiendas";
            this.Load += new System.EventHandler(this.Tiendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaTiendas;
        private System.Windows.Forms.Button nuevaTienda;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn vendedor;
    }
}