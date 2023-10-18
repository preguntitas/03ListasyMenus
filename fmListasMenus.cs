using System;
using System.Collections;
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
            if (e.KeyChar == (char)13) // Si se pulsa intro
            {
                btAnyadir.PerformClick(); // Ejecutamos evento click del botón Añadir
            }
        }

        private void btAnyadir_Click(object sender, EventArgs e)
        {
            if (ckOrdenar.Checked)
            {
                MessageBox.Show("No se puede añadir con marca Ordenar Activa");
                return;
            }
            if (tbAlumno.Text == "")
            {
                MessageBox.Show("Introduce nombre.");
            }
            else
            {
                if (lbAlumnos.Items.IndexOf(tbAlumno.Text) > -1)
                {
                    MessageBox.Show("El nombre ya existe.");
                }
                else
                {
                    lbAlumnos.Items.Add(tbAlumno.Text);
                }
            }
            tbAlumno.SelectAll();
            tbAlumno.Focus();

        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (lbAlumnos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un Alumno");
            }
            else
            {
                lbAlumnos.Items.RemoveAt(lbAlumnos.SelectedIndex);
            }
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (ckOrdenar.Checked)
            {
                MessageBox.Show("No se puede añadir con marca Ordenar Activa");
                return;
            }
            tbAlumno.SelectAll();
            if (tbAlumno.Text == "")//comprueba que hay algo que insertar
            {
                MessageBox.Show("Introduce Nombre");
                tbAlumno.Focus();
            }
            else
            {
                if (lbAlumnos.SelectedIndex < 0)//Comprobamos posición en lista
                {
                    MessageBox.Show("Elige posición en la lista");
                }
                else
                {
                    if (lbAlumnos.Items.IndexOf(tbAlumno.Text) == -1)
                    { //Comprobamos si existe alumno
                        lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex, tbAlumno.Text);
                    }
                    else
                    {
                        MessageBox.Show("El alumno ya existe");
                        tbAlumno.Focus();
                    }
                }
            }

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbAlumno.Text == "")
            {
                MessageBox.Show("Introduce Nombre");
            }
            else
            {
                if (lbAlumnos.Items.IndexOf(tbAlumno.Text) == -1)
                {
                    MessageBox.Show("No existe");
                }
                else
                {
                    lbAlumnos.SelectedIndex =
                    lbAlumnos.Items.IndexOf(tbAlumno.Text);
                }
            }
            tbAlumno.Focus();
        }

        private void btArriba_Click(object sender, EventArgs e)
        {
            ckOrdenar.Checked = false;
            int miindex = lbAlumnos.SelectedIndex;
            if (lbAlumnos.SelectedIndex > 0)
            {
                lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex - 1,
                lbAlumnos.SelectedItem);
                lbAlumnos.Items.RemoveAt(lbAlumnos.SelectedIndex);
                lbAlumnos.SelectedIndex = miindex - 1;
            }
        }

        private void btAbajo_Click(object sender, EventArgs e)
        {
            ckOrdenar.Checked = false;
            if (lbAlumnos.SelectedIndex == -1) return; //Si no hay selección se produce un error
            if (lbAlumnos.SelectedIndex < lbAlumnos.Items.Count - 1)
            {
                int miindex = lbAlumnos.SelectedIndex;
                lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex + 2,
                lbAlumnos.SelectedItem.ToString());
                lbAlumnos.Items.RemoveAt(miindex);
                lbAlumnos.SelectedIndex = miindex + 1;
            }
                    }

        private void btMostrarTodos_Click(object sender, EventArgs e)
        {
            string mostrartodos = "Numero\tNombre\n";
            for (int i = 0; i <= lbAlumnos.Items.Count - 1; i++)
            {
                //MessageBox.Show("el alumno nº: " + (i + 1).ToString() + " es " + lbAlumnos.Items[i]); //para mostrar uno a uno
            mostrartodos = mostrartodos + (i + 1) + " \t" +
            lbAlumnos.Items[i] + "\n";
        }
        MessageBox.Show(mostrartodos);
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if (lbAlumnos.SelectedIndex < 0) // Indice elemento seleccionado o -1 
                //si no hay selección
            {
                MessageBox.Show("selecciona un alumno");
            }
            else
            {
                // MessageBox.Show("El primero de la lista es "+lbAlumnos.Items[0]);
                // MessageBox.Show(lbAlumnos.SelectedIndex.ToString());
                MessageBox.Show(
                "El Seleccionado es:" + lbAlumnos.Items[lbAlumnos.SelectedIndex] +
                " Ocupa la posición " + Convert.ToString(lbAlumnos.SelectedIndex + 1));
            }
            /* Otro ejemplo de mostrar seleccion de un elemento 
            if (lbAlumnos.SelectedIndex > -1) 
            { 
            MessageBox.Show("El elemento elegido es " + 
            lbAlumnos.Items[lbAlumnos.SelectedIndex]); 
            } 
            */

        }

        private void ckOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            lbAlumnos.Sorted = ckOrdenar.Checked;

        }

        private void ckActualizar_CheckedChanged(object sender, EventArgs e)
        {
            laNuevo.Enabled = ckActualizar.Checked;
            tbAlumno.Enabled = ckActualizar.Checked;
            pnActualiza.Visible = ckActualizar.Checked;
            if (pnActualiza.Visible)
                ckActualizar.BackColor = Color.Green;
            else
                ckActualizar.BackColor = Color.Red;
        }

        private void fmListasMenus_Load(object sender, EventArgs e)
        {
            cbCursos.SelectedIndex = 0; // Seleccionamos ítem 1 del ComboBox 
            mostrarListbox(); // Cargamos nombres guardados en el archivo 
                              // indicado en el ComboBox en el ListBox
        }

        private void itNuevo_Click(object sender, EventArgs e)
        {
            lbAlumnos.Items.Clear();
        }

        
    }
}
