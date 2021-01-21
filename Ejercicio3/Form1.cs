using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string so= sel_SO();
            string esp = sel_Especialidad();
            MessageBox.Show($"El sistema selecionado es: {so}\nSu/s especialidad/es es/son: {esp}\nHoras de uso: {trackBar1.Value.ToString()}h");
          
        }


        private string sel_Especialidad()
        {
            List<string> cbSelect = new List<string>();

            if (clbEspecialidad.GetItemChecked(0))
            {
                cbSelect.Add("Programación");
            }
            if (clbEspecialidad.GetItemChecked(1))
            {
                cbSelect.Add("Diseño Gráfico");
            }
            if (clbEspecialidad.GetItemChecked(2))
            {
                cbSelect.Add("Administración");
            }


            string res = string.Join(", ", cbSelect.ToArray());

            return res;
        }

        private string sel_SO()
        {
            if (rbWindows.Checked)
            {
                return  "Windows";
            }
            else if (rbMac.Checked)
            {
                return  "Mac";
            }
            else
            {
                return  "Linux";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblHoras.Text = "Horas : " + trackBar1.Value.ToString();
        }
    }
}
