﻿namespace SEM
{
    partial class Evaluate
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
            this.cbMaestro = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tbCalificacion = new System.Windows.Forms.TrackBar();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaestro
            // 
            this.cbMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbMaestro.FormattingEnabled = true;
            this.cbMaestro.Location = new System.Drawing.Point(280, 76);
            this.cbMaestro.Name = "cbMaestro";
            this.cbMaestro.Size = new System.Drawing.Size(455, 33);
            this.cbMaestro.TabIndex = 0;
            this.cbMaestro.SelectedIndexChanged += new System.EventHandler(this.cbMaestro_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(280, 169);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(455, 33);
            this.cbMateria.TabIndex = 1;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(280, 247);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(455, 271);
            this.txtComentarios.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 749);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 749);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // tbCalificacion
            // 
            this.tbCalificacion.Location = new System.Drawing.Point(320, 592);
            this.tbCalificacion.Name = "tbCalificacion";
            this.tbCalificacion.Size = new System.Drawing.Size(379, 45);
            this.tbCalificacion.TabIndex = 5;
            this.tbCalificacion.Tag = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnGuardar.Location = new System.Drawing.Point(451, 672);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Evaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 749);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbCalificacion);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbMaestro);
            this.Name = "Evaluate";
            this.Text = "Evaluate";
            ((System.ComponentModel.ISupportInitialize)(this.tbCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaestro;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TrackBar tbCalificacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}