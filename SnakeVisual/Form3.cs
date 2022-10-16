using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mundo;

namespace SnakeVisual
{
    public partial class SnakeAppNivel : Form
    {
        readonly Mundos mundo;
        readonly Juego jugar;
        CabezaSerpiente.Direccion direccion;

        private Image DevuelveImagen(ObjetosMundos objeto)
        {
            if (objeto != null)
            {
                if (objeto is CabezaSerpiente)
                {
                    if (!jugar.PuedesJugar)
                    {
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Abajo) return Image.FromFile("Pictures\\CabezaMAbajo.png");
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Arriba) return Image.FromFile("Pictures\\CabezaMArriba.png");
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Derecha) return Image.FromFile("Pictures\\CabezaMDerecha.png");
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Izquierda) return Image.FromFile("Pictures\\CabezaMIzquierda.png");
                    }
                    else
                    {
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Abajo) return Image.FromFile("Pictures\\CabezaNAbajo.png");
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Arriba) return Image.FromFile("Pictures\\CabezaNArriba.png");
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Derecha) return Image.FromFile("Pictures\\CabezaNDerecha.png");
                        if ((objeto as CabezaSerpiente).Dir == CabezaSerpiente.Direccion.Izquierda) return Image.FromFile("Pictures\\CabezaNIzquierda.png");
                    }
                }
                if (objeto is Huevos) return Image.FromFile("Pictures\\Huevo.png");
                if (objeto is Obstaculos) return Image.FromFile("Pictures\\Obstaculo.png");
                if (objeto is CuerpoSerpiente) return Image.FromFile("Pictures\\Cuerpo.png");
            }
            return null;
        }
        public SnakeAppNivel(Mundos mundo)
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
            this.mundo = mundo;
            int cantidad = this.mundo.Cantidad;
            jugar = new Juego(this.mundo);
            jugar.GeneraHuevo(cantidad);
            jugar.InsertarSerpiente();
            direccion = jugar.cabezaS.Dir;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            SnakeApp snakeApp = new SnakeApp();
            snakeApp.Show();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics gr = e.Graphics;
            int filas = mundo.ObjetosMundo.GetLength(0);
            int columnas = mundo.ObjetosMundo.GetLength(1);
            float cellWidth = (pictureBox1.Width - 1f) / columnas;
            float cellHeight = (pictureBox1.Height - 1f) / filas;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (DevuelveImagen(mundo.ObjetosMundo[i, j]) != null) gr.DrawImage(DevuelveImagen(mundo.ObjetosMundo[i, j]), j * cellWidth, i * cellHeight, cellWidth - 1, cellHeight - 1);
                    if (mundo.ObjetosMundo[i, j] is Huevos)
                    {
                        StringFormat stringFormat = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        gr.DrawString(((Huevos)mundo.ObjetosMundo[i, j]).Numero.ToString(), new Font("Showcard gothic", 11, FontStyle.Regular), new SolidBrush(Color.Black), new RectangleF(j * cellWidth, i * cellHeight, cellWidth - 1, cellHeight - 1), stringFormat);
                    }
                }
            }
            label2.Text = mundo.DarPuntuacion.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (mundo.Velocidad == 1) timer1.Interval = 605;
            if (mundo.Velocidad == 2) timer1.Interval = 420;
            if (mundo.Velocidad == 3) timer1.Interval = 135;
            timer1.Start();
            button1.Visible = false;
        }

        private void SnakeAppNivel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void SnakeAppNivel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direccion == CabezaSerpiente.Direccion.Abajo) direccion = CabezaSerpiente.Direccion.Abajo;
                    else direccion = CabezaSerpiente.Direccion.Arriba;
                    break;
                case Keys.Right:
                    if (direccion == CabezaSerpiente.Direccion.Izquierda) direccion = CabezaSerpiente.Direccion.Izquierda;
                    else direccion = CabezaSerpiente.Direccion.Derecha;
                    break;
                case Keys.Down:
                    if (direccion == CabezaSerpiente.Direccion.Arriba) direccion = CabezaSerpiente.Direccion.Arriba;
                    else direccion = CabezaSerpiente.Direccion.Abajo;
                    break;
                case Keys.Left:
                    if (direccion == CabezaSerpiente.Direccion.Derecha) direccion = CabezaSerpiente.Direccion.Derecha;
                    else direccion = CabezaSerpiente.Direccion.Izquierda;
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SnakeApp snakeApp = new SnakeApp();
            if (jugar.Ganas)
            {
                timer1.Stop();
                MessageBox.Show("Felicidades! Usted ha ganado \nPuntuación: " + mundo.DarPuntuacion.ToString());
                this.Visible = false;
                snakeApp.Visible = true;
                return;
            }
            jugar.Movimiento(direccion);
            pictureBox1.Invalidate();
            if (!jugar.PuedesJugar)
            {
                timer1.Stop();
                MessageBox.Show("Uhh! Usted ha perdido \nPuntuación: " + mundo.DarPuntuacion.ToString()+ "\nInténtelo de nuevo");
                this.Visible = false;
                snakeApp.Visible = true;
                return;
            }
            pictureBox1.Invalidate();
        }
    }
}
