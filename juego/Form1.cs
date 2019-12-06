using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    public partial class Form1 : Form
    {

        // areglo de strings con el nombre los pokemons disponibles
        //debido a un problema con el manejo de los turnos entre cpu y jugador los nombres de los pokemon quedaron descartados del proyecto
        //por cuestiones de tiempo


        string[] pokemon = new string[] { "Blastoise", "Totodile", "Venasaur", "Zeptail", "Charizard", "Blayzen", "Pikachu", "Electabuz" };
       // SoundPlayer audio = new SoundPlayer("music.wav");
        string mi_pokemon;
        bool goleft = false;//variable boleana que controla el movimiento hacia la izquierda del jugador
        bool goright = false;//variable boleana que controla el movimiento hacia la derecha del jugador
        bool godown = false;//variable boleana que controla el movimiento hacia abajo del jugador
        bool goup = false;//variable boleana que controla el movimiento hacia arriba del jugador
        int contador = 0;//variable que permite el cambio de pantalla hacia la batalla
        //metodo que detecta eventos dentro de la pantalla en este caso la opresion de teclas
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {    //deteccion de la tecla de flecha izquierda
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;// asignacion de la variable boleana goleft servira más adelante en el codigo
            }
            //deteccion de la tecla de flecha derecha
            if (e.KeyCode == Keys.Right)
            {
                goright = true;//asignacion de la variable boleana goright servira más adelante en el codigo
            }
            //deteccion de la tecla de flecha de arriba
            if (e.KeyCode == Keys.Up)
            {
                goup = true; ;//asignacion de la variable boleana goup servira más adelante en el codigo


            }
            //deteccion de la tecla de flecha abajo
            if (e.KeyCode == Keys.Down)
            {
                godown = true; ;//asignacion de la variable boleana godown servira más adelante en el codigo


            }
        }

        //metodo que detecta cuando las teclas se levantaron
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;

            }
        }

        public Form1()
        {     //inicalizacion de componentes
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();//clase aleatorio
            int random = rnd.Next(0, 8);//random entre 0 y 7
            mi_pokemon = pokemon[random];// asignacion de pokemon de acuerdo al aleatorio y arreglo de strings(por tiempo funciona pero no es relevante para el juego)



            try
            {
               
         //       audio.Play();
            }
            catch(Exception ex)
            {

            }
        }
        //metodo de actualizacion del timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //condicion si goleft es true
            if (goleft)
            {
                //asignacion de images dentro de los picturesbox para dar origen a los sprites

                pictureBox2.Image = Properties.Resources.movimientos_2_png__4_;
                pictureBox2.Update();//permite la actualizacion de la imagen simulando la animacion
                pictureBox2.Image = Properties.Resources.movimientos_2_png__5_;
                pictureBox2.Update();//permite la actualizacion de la imagen simulando la animacion
                pictureBox2.Image = Properties.Resources.movimientos_2_png__3_;
                pictureBox2.Left=pictureBox2.Left-5;//movimiento de la picture box hacia la izquierda
                label2.Text = "Walking to left()";//impresion en pantalla de lo que "esta haciendo el codigo" se muestra en la parte superior izquierda

            }
            if (goright)
            {
                pictureBox2.Image = Properties.Resources.movimientos_2_png__2_;
               label2.Text = "Walking to right()";
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos__1_1;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__2_;
                pictureBox2.Left = pictureBox2.Left + 5;//movimiento hacia arriba



            }
            if (godown)
            {
                label2.Text = "Walking to down()";
                pictureBox2.Image = Properties.Resources.movimientos_2_png__6_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__7_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__8_;
               
                pictureBox2.Top=pictureBox2.Top+5;//movimiento hacia abajo

            }
            if (goup)
            {
                label2.Text = "Walking to up()";
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__11_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__9_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__10_;

                pictureBox2.Top=pictureBox2.Top-5;//movimiento hacia a arriba

            }
            //instruccion que detecta sin una picture box "esta chocando con otra" usada para no traspasar arboles ni casas y encontrar a los rivales

            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top+5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left - 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left + 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left - 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left + 5;//movimiento del personaje hacia el lado contrario para evitar traspasar el objeto

            }
           
            if (pictureBox2.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left - 10;

                label3.Text = "NO PUEDES ENFRENTAR";//se muestra en pantalla el "dialogo" de un personaje que no quiere luchar con el jugador
                label3.Visible = true;//se muestra en pantalla ya que antes permanece oculto
            }



            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds) && contador==0)
            {
                Form2 a = new Form2(mi_pokemon);//instancia de la ventana de batalla
                a.Show();//se muestra la nueva ventana
                this.SetVisibleCore(false);//se oculta la ventana actual
                contador++;//se activa el contador para que no siga entrando en la condicion

                timer1.Stop();//se detiene el timer de esta pantall

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
