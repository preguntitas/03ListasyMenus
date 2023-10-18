using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasyMenus
{
    public partial class fmListasMenus : Form
    {
        public fmListasMenus()
        {
            InitializeComponent();
        }

        private void ItArchivo_Click(object sender, EventArgs e)
        {
            lbAlumnos.Items.Clear();
        }

        private void itAbrir_Click(object sender, EventArgs e)
        {
            mostrarListbox();
        }
        public void mostrarListbox()
        {
            lbAlumnos.Items.Clear();
            try
            {//@ actúa como prefijo de un elemento de código que el compilador
             //interpreta como identificador en lugar de cómo palabra clave de C#,
             //es decir,anula la interpretación de los caracteres especiales
             //y secuencias de escape como la \ 
                 StreamReader miarchivo = new StreamReader(@".\cursos\" +
                    cbCursos.Text + ".txt"); //nombre mostrado en combobox
                while (miarchivo.Peek() >= 0)
                {
                    lbAlumnos.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                }
                miarchivo.Close();
            }
            catch (Exception mierror)
            {
                MessageBox.Show(mierror.Message);
            }
        }

        private void itGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter miarchivo = new StreamWriter(@".\cursos\"
                + cbCursos.Text + ".txt");
                foreach (object lista in lbAlumnos.Items)
                {
                    miarchivo.WriteLine(lista.ToString());
                }
                miarchivo.Close();
            }
            catch (Exception mierror)
            {
                MessageBox.Show(mierror.Message);
            }
        }

        private void itSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbCursos_TextChanged(object sender, EventArgs e)
        {
            mostrarListbox();
        }

        private void tbAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
