﻿namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class ABMVisibilidad
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
            this.volverButton = new System.Windows.Forms.Button();
            this.tablaVisibilidad = new System.Windows.Forms.DataGridView();
            this.modificarButton = new System.Windows.Forms.Button();
            this.nuevaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVisibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(736, 241);
            this.volverButton.Margin = new System.Windows.Forms.Padding(4);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(100, 47);
            this.volverButton.TabIndex = 8;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // tablaVisibilidad
            // 
            this.tablaVisibilidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaVisibilidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaVisibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVisibilidad.GridColor = System.Drawing.SystemColors.Window;
            this.tablaVisibilidad.Location = new System.Drawing.Point(13, 60);
            this.tablaVisibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.tablaVisibilidad.MultiSelect = false;
            this.tablaVisibilidad.Name = "tablaVisibilidad";
            this.tablaVisibilidad.ReadOnly = true;
            this.tablaVisibilidad.RowHeadersVisible = false;
            this.tablaVisibilidad.Size = new System.Drawing.Size(823, 149);
            this.tablaVisibilidad.TabIndex = 7;
            this.tablaVisibilidad.Click += new System.EventHandler(this.tablaVisibilidad_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(121, 14);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(4);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(100, 28);
            this.modificarButton.TabIndex = 6;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // nuevaButton
            // 
            this.nuevaButton.Location = new System.Drawing.Point(13, 14);
            this.nuevaButton.Margin = new System.Windows.Forms.Padding(4);
            this.nuevaButton.Name = "nuevaButton";
            this.nuevaButton.Size = new System.Drawing.Size(100, 28);
            this.nuevaButton.TabIndex = 5;
            this.nuevaButton.Text = "Nueva";
            this.nuevaButton.UseVisualStyleBackColor = true;
            this.nuevaButton.Click += new System.EventHandler(this.nuevaButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.tablaVisibilidad);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.nuevaButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABMVisibilidad";
            this.Text = "ABMVisibilidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMVisibilidad_FormClosing);
            this.Load += new System.EventHandler(this.ABMVisibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVisibilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.DataGridView tablaVisibilidad;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button nuevaButton;
        private System.Windows.Forms.Button button1;
    }
}