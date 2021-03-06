﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM.Forms
{
    public partial class EditAccount : Form
    {
        Conexion c = null;
        public EditAccount(Conexion c)
        {
         
            InitializeComponent();
            this.c = c;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lbCarrera.Text = c.CARRERA;
            panelOpciones.Location = new Point((this.Width / 2 - panelOpciones.Width / 2), (this.Height / 2 - panelOpciones.Height / 2));
            panelBorrar.Location = new Point((this.Width / 2 - panelBorrar.Width / 2), (this.Height / 2 - panelBorrar.Height / 2));
            panelContra.Location = new Point((this.Width / 2 - panelContra.Width / 2), (this.Height / 2 - panelContra.Height / 2));
            panelCarrera.Location = new Point((this.Width / 2 - panelCarrera.Width / 2), (this.Height / 2 - panelCarrera.Height / 2));
            panelBorrar.Visible = false;
            panelContra.Visible = false;
            panelCarrera.Visible = false;
            btnRegresar.Location = new Point((this.Width-btnRegresar.Width), (this.Height/2+panelOpciones.Height/2));

        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            panelCarrera.Visible = true;
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            panelContra.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            panelBorrar.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c.CONTRA==txtContra.Text)
            {
                if (txtContra.Text==txtNewContra.Text)
                {
                    MessageBox.Show("No puede ser la misma contraseña");
                }
                else
                {
                    String check = validarContra(txtNewContra.Text);
                    if (check==" ")
                    {
                        try
                        {
                            c.ChangePass(txtNewContra.Text);
                            this.Hide();
                            MessageBox.Show("Contraseña cambiada satisfactoriamente");
                            new Searcher(c).Show();
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                        }
                        }
                    else
                    {
                        MessageBox.Show(check);
                    }

                }
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
        public String validarContra(String Pass)
        {

            String Errores = " ";
            if (Pass.Length == 0 )
            {
                Errores = "La contraseña no puede esta vacia";
            }

          
            if (Pass.Length < 9)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contar con almenos 9 caracteres";
            }
         
            if (Pass.Count(char.IsLower) < 1)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contener minusculas";
            }
            if (Pass.Count(char.IsUpper) < 1)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contener mayusculas";
            }
            /* if (Pass.Count(char.is) < 2)
             {
                 Errores = Errores + Environment.NewLine + "La contraseña debe contener caracteres especiales";
             }*/
           

            if (Pass.Count(char.IsDigit) < 2)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe de tener al menos 2 numeros";
            }
           


            return Errores;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtContraBorrar.Text==c.CONTRA)
            {
                try
                {
                    c.DeleteUser();
                    MessageBox.Show("Usuario eliminado correctamente");
                    this.Hide();
                    new AccountMenu(c).Show();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
              
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }

        private void BtnComfirPass_Click(object sender, EventArgs e)
        {

        }
    }
}
