using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    public partial class Form1 : Form
    {

        string[] pokemon = new string[] { "Blastoise", "Totodile", "Venasaur", "Zeptail", "Charizard", "Blayzen", "Pikachu", "Electabuz" };
      
        string mi_pokemon;
        bool goleft = false;
        bool goright = false;
        bool godown = false;
        bool goup = false;
        int contador = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;

            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;

            }
        }
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
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 8);
            mi_pokemon = pokemon[random];
           
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (goleft)
            {
                
                pictureBox2.Image = Properties.Resources.movimientos_2_png__4_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__5_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__3_;
                pictureBox2.Left=pictureBox2.Left-5;
                label2.Text = "Walking to left()";

            }
            if (goright)
            {
                pictureBox2.Image = Properties.Resources.movimientos_2_png__2_;
               label2.Text = "Walking to right()";
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos__1_1;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__2_;
                pictureBox2.Left = pictureBox2.Left + 5;


            }
            if (godown)
            {
                label2.Text = "Walking to down()";
                pictureBox2.Image = Properties.Resources.movimientos_2_png__6_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__7_;
                pictureBox2.Update();
                pictureBox2.Image = Properties.Resources.movimientos_2_png__8_;
               
                pictureBox2.Top=pictureBox2.Top+5;
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

                pictureBox2.Top=pictureBox2.Top-5;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top+5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;
                
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left - 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top - 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                pictureBox2.Top = pictureBox2.Top + 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left + 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left - 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left + 5;

            }
           
            if (pictureBox2.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                pictureBox2.Left = pictureBox2.Left - 10;

                label3.Text = "NO LUCHARE";
                label3.Visible = true;
            }



            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds) && contador==0)
            {
                Form2 a = new Form2(mi_pokemon);
                a.Show();
                this.SetVisibleCore(false);
                contador++;
                timer1.Stop();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}
