using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Mundo;

namespace SnakeVisual
{
    
    public partial class SnakeApp : Form
    {
        Mundos mundo;
        public SnakeApp()
        {
            InitializeComponent();
            butJugar.Visible = true;
            butImportar.Visible = true;
            butCrear.Visible = true;
            butVolver.Visible = false;
            butFacil.Visible = false;
            butMedio.Visible = false;
            butDificil.Visible = false;
            lblTextoRules.Visible = false;
            buttcargar.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SnakeAppCrear crear = new SnakeAppCrear();
            crear.Visible = true;
            this.Visible = false;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            butImportar.Visible = false;
            butJugar.Visible = false;
            butCrear.Visible = false;
            butFacil.Visible = false;
            butMedio.Visible = false;
            butDificil.Visible = false;
            butVolver.Visible = true;
            lblTextoRules.Visible = true;
            buttcargar.Visible = true;
        }

        private void SnakeApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            butImportar.Visible = false;
            lblTextoRules.Visible = false;
            buttcargar.Visible = false;
            butJugar.Visible = false;
            butCrear.Visible = false;
            butVolver.Visible = true;
            butFacil.Visible = true;
            butMedio.Visible = true;
            butDificil.Visible = true;

        }

        private void Bufacil_Click(object sender, EventArgs e)
        {
            List<Tuple<int, int>> posicion = new List<Tuple<int, int>>();
            posicion.Insert(0, new Tuple<int, int>(1, 5));
            posicion.Insert(0, new Tuple<int, int>(2, 9));
            posicion.Insert(0, new Tuple<int, int>(3, 9));
            posicion.Insert(0, new Tuple<int, int>(4, 3));
            posicion.Insert(0, new Tuple<int, int>(5, 5));
            posicion.Insert(0, new Tuple<int, int>(5, 7));
            posicion.Insert(0, new Tuple<int, int>(6, 9));
            posicion.Insert(0, new Tuple<int, int>(11, 3));
            mundo = new Mundos(12, 14, posicion, 6, 1);
            SnakeAppNivel snakeAppNivel = new SnakeAppNivel(mundo);
            snakeAppNivel.Visible = true;
            this.Visible = false;
        }

        private void Butmedio_Click(object sender, EventArgs e)
        {
            List<Tuple<int, int>> posicion = new List<Tuple<int, int>>();
            posicion.Insert(0, new Tuple<int, int>(0, 1));
            posicion.Insert(0, new Tuple<int, int>(0, 8));
            posicion.Insert(0, new Tuple<int, int>(1, 5));
            posicion.Insert(0, new Tuple<int, int>(2, 5));
            posicion.Insert(0, new Tuple<int, int>(2, 7));
            posicion.Insert(0, new Tuple<int, int>(3, 9));
            posicion.Insert(0, new Tuple<int, int>(4, 10));
            posicion.Insert(0, new Tuple<int, int>(5, 5));
            posicion.Insert(0, new Tuple<int, int>(5, 7));
            posicion.Insert(0, new Tuple<int, int>(6, 10));
            posicion.Insert(0, new Tuple<int, int>(7, 13));
            posicion.Insert(0, new Tuple<int, int>(9, 0));
            posicion.Insert(0, new Tuple<int, int>(10, 13));
            posicion.Insert(0, new Tuple<int, int>(11, 9));
            posicion.Insert(0, new Tuple<int, int>(12, 1));
            posicion.Insert(0, new Tuple<int, int>(13, 5));
            posicion.Insert(0, new Tuple<int, int>(13, 8));
            mundo = new Mundos(14, 15, posicion, 5, 2);
            SnakeAppNivel snakeAppNivel = new SnakeAppNivel(mundo);
            snakeAppNivel.Visible = true;
            this.Visible = false;
        }

        private void Butdificil_Click(object sender, EventArgs e)
        {
            List<Tuple<int, int>> posicion = new List<Tuple<int, int>>();
            posicion.Insert(0, new Tuple<int, int>(0, 5));
            posicion.Insert(0, new Tuple<int, int>(0, 7));
            posicion.Insert(0, new Tuple<int, int>(0, 9));
            posicion.Insert(0, new Tuple<int, int>(1, 3));
            posicion.Insert(0, new Tuple<int, int>(1, 3));
            posicion.Insert(0, new Tuple<int, int>(1, 8));
            posicion.Insert(0, new Tuple<int, int>(2, 3));
            posicion.Insert(0, new Tuple<int, int>(2, 5));
            posicion.Insert(0, new Tuple<int, int>(3, 5));
            posicion.Insert(0, new Tuple<int, int>(3, 16));
            posicion.Insert(0, new Tuple<int, int>(4, 17));
            posicion.Insert(0, new Tuple<int, int>(5, 13));
            posicion.Insert(0, new Tuple<int, int>(6, 1));
            posicion.Insert(0, new Tuple<int, int>(6, 9));
            posicion.Insert(0, new Tuple<int, int>(6, 15));
            posicion.Insert(0, new Tuple<int, int>(8, 3));
            posicion.Insert(0, new Tuple<int, int>(9, 14));
            posicion.Insert(0, new Tuple<int, int>(10, 5));
            posicion.Insert(0, new Tuple<int, int>(11, 9));
            posicion.Insert(0, new Tuple<int, int>(12, 3));
            posicion.Insert(0, new Tuple<int, int>(14, 5));
            posicion.Insert(0, new Tuple<int, int>(14, 17));
            posicion.Insert(0, new Tuple<int, int>(15, 13));
            posicion.Insert(0, new Tuple<int, int>(15, 15));
            posicion.Insert(0, new Tuple<int, int>(16, 9));
            posicion.Insert(0, new Tuple<int, int>(17, 3));
            mundo = new Mundos(18, 19, posicion, 5, 3);
            SnakeAppNivel snakeAppNivel = new SnakeAppNivel(mundo);
            snakeAppNivel.Visible = true;
            this.Visible = false;
        }

        private void ButVolver_Click(object sender, EventArgs e)
        {
            butImportar.Visible = true;
            butJugar.Visible = true;
            butCrear.Visible = true;
            butVolver.Visible = false;
            butFacil.Visible = false;
            butMedio.Visible = false;
            butDificil.Visible = false;
            lblTextoRules.Visible = false;
            buttcargar.Visible = false;
        }

        private void Buttcargar_Click(object sender, EventArgs e)
        {
            archivo.ShowDialog();
            string sLine = "";
            int filas;
            int columnas;
            int cantidad;
            int velocidad;
            List<string> arrText = new List<string>();
            string archivo1 = archivo.FileName;
            if (archivo1 == "archivo") return;
            if (!archivo1.Contains(".txt"))
            {
                MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                return;
            }
            StreamReader sr = new StreamReader(archivo1);
            while (sLine != null)
            {
                sLine = sr.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            if (arrText.Count < 4)
            {
                MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                return;
            }
            try
            {
                filas = int.Parse(arrText[0]);
                columnas = int.Parse(arrText[1]);
                cantidad = int.Parse(arrText[arrText.Count - 2]);
                velocidad = int.Parse(arrText[arrText.Count - 1]);
            }
            catch(FormatException)
            {
                MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                return;
            }
            if (velocidad < 1 || velocidad > 3)
            {
                MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                return;
            }
            sr.Close();
            List<Tuple<int, int>> posicion = new List<Tuple<int, int>>();
            string s1 = "";
            string s2 = "";
            bool hubocambio = false;
            for (int i = 2; i < arrText.Count - 2; i++)
            {
                for (int j = 0; j < arrText[i].Length; j++)
                {
                    if (!arrText[i].Contains(",")) { MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!"); return; }
                    if ((arrText[i])[j] == ',') { hubocambio = true; continue; }
                    if (!hubocambio) s1 += (arrText[i])[j].ToString();
                    else if (hubocambio) s2 += (arrText[i])[j].ToString();
                }
                try { posicion.Insert(0, new Tuple<int, int>(int.Parse(s1), int.Parse(s2))); }
                catch (FormatException)
                {
                    MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                    return;
                }
                s1 = "";
                s2 = "";
                hubocambio = false;
            }
            try { mundo = new Mundos(filas, columnas, posicion, cantidad, velocidad); }
            catch (FormatException)
            {
                MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No cumple con el formato establecido, por favor léase las instrucciones!!!");
                return;
            }
            Juego juego = new Juego(mundo);
            if (juego.EsValido())
            {
                SnakeAppNivel snakeAppNivel = new SnakeAppNivel(mundo);
                snakeAppNivel.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Este mundo es Inválido!!!, por favor léase las instrucciones");
                return;
            }
        }
    }
}
