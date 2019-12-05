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
    public partial class Form2 : Form
    { 

        string[] ataques_agua = new string[] { "hidrobomba", "Burbuja" };
        string[] ataques_fuego = new string[] { "lanzallamas", "fuego" };
        string[] ataques_elect = new string[] { "rayo", "trueno" };
        string[] ataques_planta = new string[] { "golpe", "rafaga" };
        string[] mis_ataques = new string[4];
        string[] ataques_cpu = new string[4];
        bool turnojugado=false;
        bool ataque_agua, ataque_elect, ataque_planta, ataque_fuego, ataque_agua_cpu, ataque_elect_cpu, ataque_planta_cpu, ataque_fuego_cpu;
        int posicion_mia,posicion_mia2, posicion_cpu, posicion_cpu2;
        int vida_cpu = 100;
        int vida_jugador = 100;

        private void timer2_Tick(object sender, EventArgs e)
        {
            Atacar_cpu();
        }

        String mi_pokemon;
        String pokemon_cpu;

       
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String pokemon_actual)
        {
            mi_pokemon = pokemon_actual;
            InitializeComponent();
           
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            timer1.Start();


            /*if (mi_pokemon == "Blastoise" || mi_pokemon == "Totodile")
            {
                string[] pokemon = new string[] { "Charizard", "Blayzen" };
                int random = rnd.Next(0, 2);
                pokemon_cpu = pokemon[random];

            }
            if (mi_pokemon == "Pikachu" || mi_pokemon == "Electabuz")
            {
                string[] pokemon = new string[] { "Blastoise", "Totodile" };
                int random = rnd.Next(0, 2);
                pokemon_cpu = pokemon[random];
            }
            if (mi_pokemon == "Blayzen" || mi_pokemon == "Charizard")
            {
                string[] pokemon = new string[] { "Zeptail", "Venasaur" };
                int random = rnd.Next(0, 2);
                pokemon_cpu = pokemon[random];
            }
            if (mi_pokemon == "Zeptail" || mi_pokemon == "Venasaur")
            {
                string[] pokemon = new string[] { "Blastoise", "Totodiles" };
                int random = rnd.Next(0, 2);
                pokemon_cpu = pokemon[random];
            }*/

            int ran = rnd.Next(0, 2);
            mis_ataques[0] = ataques_agua[ran];
            mis_ataques[1] = ataques_elect[ran];
            mis_ataques[2] = ataques_planta[ran];
            mis_ataques[3] = ataques_fuego[ran];
            label2.Text = mis_ataques[0];
            label3.Text = mis_ataques[1];
            label4.Text = mis_ataques[2];
            label5.Text = mis_ataques[3];
            int ran2 = rnd.Next(0, 2);
            ataques_cpu[0] = ataques_agua[ran2];
            ataques_cpu[1] = ataques_elect[ran2];
            ataques_cpu[2] = ataques_planta[ran2];
            ataques_cpu[3] = ataques_fuego[ran2];

            posicion_mia = pictureBox1.Left;
            posicion_mia2 = pictureBox1.Top;
            posicion_cpu = pictureBox2.Left;
            posicion_cpu2 = pictureBox2.Top;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Atacar();
        
        }
        private void Atacar(){
            
          

            Random rnd = new Random();
          
            if (ataque_agua && turnojugado)
            {
                if (mis_ataques[0] == "hidrobomba")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.agua;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 30);
                    vida_cpu = vida_cpu - reducir;


                }
                if (mis_ataques[0] == "Burbuja" && turnojugado)
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.agua_Canon;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 20);
                    vida_cpu = vida_cpu - reducir;

                }
            }
           
            if (ataque_fuego && turnojugado)
            {   
                if (mis_ataques[3] == "lanzallamas")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.fuego;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 20);
                    vida_cpu = vida_cpu - reducir;

                }
                if (mis_ataques[3] == "fuego")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.aro_de_fuego;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 30);
                    vida_cpu = vida_cpu - reducir;

                }
              
            }

            if (ataque_elect && turnojugado)
            {
                if (mis_ataques[1] == "trueno")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.onda_electrica;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 20);
                    vida_cpu = vida_cpu - reducir;

                }
                if (mis_ataques[1] == "rayo")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.rayo;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 30);
                    vida_cpu = vida_cpu - reducir;

                }
               
               
             }
            if (ataque_planta)
            {
                if (mis_ataques[2] == "rafaga")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.rafaga_planta;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 20);
                    vida_cpu = vida_cpu - reducir;

                }
                if (mis_ataques[2] == "golpe")
                {
                    pictureBox2.Image = Properties.Resources.charizard_frente;
                    pictureBox2.Update();
                    pictureBox2.Image = Properties.Resources.golpe;
                    pictureBox2.Update();
                    pictureBox2.BackgroundImage = Properties.Resources.charizard_frente;
                    pictureBox1.Left += 30;
                    pictureBox1.Top -= 30;

                    int reducir = rnd.Next(10, 30);
                    vida_cpu = vida_cpu - reducir;

                }

                
            }
            if (turnojugado)
            {
                pictureBox1.Left = posicion_mia;
                pictureBox1.Top = posicion_mia2;
                pictureBox2.Left = posicion_cpu;
                pictureBox2.Top = posicion_cpu2;
                pictureBox2.Image = Properties.Resources.charizard_frente;
                 
                
            }
            timer2.Start();
            if (vida_cpu <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Haz ganado felicidades", "", buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    
                    this.Close();
                   
                }
            }
            label13.Text = vida_cpu.ToString();
           

        }
        private void Atacar_cpu()
        {
          
            Random rnd = new Random();
            int aleatorio = rnd.Next(1, 5);
            if (aleatorio == 1)
            {
                ataque_agua_cpu = true;
            }
            if (aleatorio == 2)
            {
                ataque_elect_cpu = true;
            }
            if (aleatorio == 3)
            {
                ataque_planta_cpu = true;
            }
            if (aleatorio == 4)
            {
                ataque_fuego_cpu = true;
            }
            if (ataque_agua_cpu && turnojugado)
            {
                if (ataques_cpu[0] == "hidrobomba")
                {

                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.agua;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 30);
                    vida_jugador = vida_jugador - reducir;

                }
                if (ataques_cpu[0] == "Burbuja")
                {

                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.agua_Canon;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 20);
                    vida_jugador = vida_jugador - reducir;

                }

                ataque_agua_cpu = false;
                turnojugado = false;
            }

            if (ataque_fuego_cpu && turnojugado)
            {
                if (ataques_cpu[3] == "lanzallamas")
                {

                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.fuego;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 20);
                    vida_jugador = vida_jugador - reducir;

                }
                if (ataques_cpu[3] == "fuego")
                {

                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.aro_de_fuego;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 30);
                    vida_jugador = vida_jugador - reducir;

                }
                ataque_fuego_cpu = false;

                turnojugado = false;
            }

            if (ataque_elect_cpu && turnojugado)
            {
                if (ataques_cpu[1] == "trueno")
                {
                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.onda_electrica;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 20);
                    vida_jugador = vida_jugador - reducir;

                }
                if (ataques_cpu[1] == "rayo")
                {
                    
                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.rayo;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 30);
                    vida_jugador = vida_jugador - reducir;

                }
                ataque_elect_cpu = false;
                turnojugado = false;
            }
            if (ataque_planta_cpu && turnojugado)
            {
                if (ataques_cpu[2] == "rafaga")
                {
                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.rafaga_planta;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 20);
                    vida_jugador = vida_jugador - reducir;

                }
                if (ataques_cpu[2] == "golpe")
                {

                    pictureBox1.Image = Properties.Resources.blastoise;
                    pictureBox1.Update();
                    pictureBox1.Image = Properties.Resources.golpe;
                    pictureBox1.Update();
                    pictureBox1.BackgroundImage = Properties.Resources.blastoise;
                    pictureBox2.Left -= 30;
                    pictureBox2.Top += 30;

                    int reducir = rnd.Next(10, 30);
                    vida_jugador = vida_jugador - reducir;

                }
                ataque_planta_cpu = false;

                turnojugado = false;
            }
            if (ataque_agua_cpu == false)
            {
                pictureBox1.Left = posicion_mia;
                pictureBox1.Top = posicion_mia2;
                pictureBox2.Left = posicion_cpu;
                pictureBox2.Top = posicion_cpu2;
                pictureBox2.Image = Properties.Resources.charizard_frente;
            }
            pictureBox1.Image = Properties.Resources.blastoise;

            if (vida_jugador <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                pictureBox3.Visible = true;
               
            }
            label14.Text = vida_jugador.ToString();
        }
       
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ataque_agua = true;
                turnojugado = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                ataque_planta = true;
                turnojugado = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                ataque_fuego = true;
                turnojugado = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                ataque_elect = true;
                turnojugado = true;
            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                ataque_agua = false;
             
            }
            if (e.KeyCode == Keys.Right)
            {
                ataque_planta = false;
               
            }
            if (e.KeyCode == Keys.Up)
            {
                ataque_fuego = false;
               
            }
            if (e.KeyCode == Keys.Down)
            {
                ataque_elect = false;
               
            }
        }
    }
}
