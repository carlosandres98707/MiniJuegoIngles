using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish
{
    public partial class Inicioform : Form
    {
        public Inicioform()
        {
            InitializeComponent();
        }

        private void Jugamos_Click(object sender, EventArgs e)
        {
           
            Pasado otraven = new Pasado();
            otraven.Visible=true;

            MessageBox.Show("Hola bienvenido a mi juego. Intenta adivinar el pasado simple de la palabra.\n" +
                "Reglas del juego:\n"+
                "Dispones de 10 intentos, una vez terminados los intendos el puntaje se reiniciara a 0 \n"+
                "Intenta conseguir el mayor numero de aciertos para sumar muchos puntajes \n"+
                "Diviertete");
                            
        }
    }
}
