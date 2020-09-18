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
    public partial class Pasado : Form
    {
        int aciertos = 0;
        int errores = 0;
        int intentos = 10;
        string[] pal_present = { "arise","awake", "be", "bear","beat","become","begin","bend","bet","bind","bid","bite","bleed","blow","break","breed", "go", "do", "write", "eat", };
        Random palabra_random = new Random();

        public Pasado()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Español_Click(object sender, EventArgs e)
        {

        }
        

        

        private void Empieza_Click(object sender, EventArgs e)
        {

            int pala = (int)Math.Floor(palabra_random.NextDouble() * pal_present.Length);
            Presente.Text = pal_present[pala];
            aciertos = 0;
            errores = 0;
            intentos = 10;
            Error.Text = errores.ToString();
            Punto.Text = aciertos.ToString();
            Pasadsimple.Text = "";
            Español.Text = "----------";
        }

        private void Pasado_Load(object sender, EventArgs e)
        {

        }

        private void Otra_Click(object sender, EventArgs e)
        {
            if (Presente.Text != "----------")
            {

                int pala = (int)Math.Floor(palabra_random.NextDouble() * pal_present.Length);

                Presente.Text = pal_present[pala];

                Pasadsimple.Text = "";
                Español.Text = "----------";

            }
            else {

                MessageBox.Show("Por favor dale al boton Empezar/Reiniciar");
            
            }


              
        }

       

        private void Verifica_Click(object sender, EventArgs e)
        {

            if (Presente.Text != "----------")
            {


                switch (Presente.Text)
                {
                    case "arise":
                        if (Pasadsimple.Text == "arose")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Surgir/Levantarse";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "awake":
                        if (Pasadsimple.Text == "awoke")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Despertarse";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "be":
                        if (Pasadsimple.Text == "was" || Pasadsimple.Text == "were")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Ser/estar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bear":
                        if (Pasadsimple.Text == "bore")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Soportar/dar a luz";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "beat":
                        if (Pasadsimple.Text == "beat")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Golpear";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "become":
                        if (Pasadsimple.Text == "became")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Llegar a Ser";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "begin":
                        if (Pasadsimple.Text == "began")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Empezar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bend":
                        if (Pasadsimple.Text == "bent")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Doblar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bet":
                        if (Pasadsimple.Text == "bet")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Apostar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bind":
                        if (Pasadsimple.Text == "bound")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Atar/Encuadernar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bid":
                        if (Pasadsimple.Text == "bid")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Pujar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bite":
                        if (Pasadsimple.Text == "bit")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Morder";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "bleed":
                        if (Pasadsimple.Text == "bled")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Sangrar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "blow":
                        if (Pasadsimple.Text == "blew")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Soplar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "break":
                        if (Pasadsimple.Text == "broke")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Romper";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }
                        break;
                    case "breed":
                        if (Pasadsimple.Text == "bred")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Criar";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }

                        break;

                    case "go":
                        if (Pasadsimple.Text == "went")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Ir";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }

                        break;
                    case "do":
                        if (Pasadsimple.Text == "did")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Hacer";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }

                        break;
                    case "write":

                        if (Pasadsimple.Text == "wrote")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Escribir";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }

                        break;
                    case "eat":
                        if (Pasadsimple.Text == "ate")
                        {
                            MessageBox.Show("Genial has acertado");
                            aciertos++;

                            Punto.Text = aciertos.ToString();

                            Español.Text = "Comer";


                        }
                        else
                        {
                            intentos--;
                            errores++;
                            MessageBox.Show("Lo siento te has equivocado. Te quedan " + intentos);
                            Error.Text = errores.ToString();

                        }

                        break;


                }
                if (intentos == 0) {

                    MessageBox.Show("Lo siento perdiste");
                    Presente.Text = "----------";
                    Error.Text = "0";
                    Punto.Text = "0";


                }
            }
            else
            {

                MessageBox.Show("Por favor dale al boton Empezar/Reiniciar");
                
            }



            
        }
    }
}
