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
    public partial class SnakeAppCrear : Form
    {
        Mundos mundo;
        Juego jugar;
        CabezaSerpiente.Direccion direccion;
        bool cambioParanopintarlineas;

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
                if(objeto is Huevos) return Image.FromFile("Pictures\\Huevo.png");
                if(objeto is Obstaculos) return Image.FromFile("Pictures\\Obstaculo.png");
                if(objeto is CuerpoSerpiente) return Image.FromFile("Pictures\\Cuerpo.png");
            }
            return null;
        }
        public SnakeAppCrear()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
            mundo = new Mundos((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            cambioParanopintarlineas = false;
            lblFilas.Visible = true;
            lblColum.Visible = true;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            numUDhuevos.Visible = false;
            numUDvelocid.Visible = false;
            lblhuevos.Visible = false;
            lblveloc.Visible = false;
            buttAcept.Visible = false;
            buttJugar.Visible = false;
            buttGuardar.Visible = false;
            buttDibuj.Visible = true;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            mundo = new Mundos((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            pictureBox1.Refresh();
            cambioParanopintarlineas = false;
            lblFilas.Visible = false;
            lblColum.Visible = false;
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            numUDhuevos.Visible = true;
            numUDvelocid.Visible = false;
            lblhuevos.Visible = true;
            lblveloc.Visible = false;
            buttDibuj.Visible = false;
            buttAcept.Visible = true;
            buttGuardar.Visible = false;
            buttJugar.Visible = false;
            pictureBox1.Enabled = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ActiveControl = null;           
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
            if (!cambioParanopintarlineas)
            {
                for (int i = 0; i <= filas; i++)
                    gr.DrawLine(Pens.Black, 0, cellHeight * i, pictureBox1.Width, cellHeight * i);
                for (int i = 0; i <= columnas; i++)
                    gr.DrawLine(Pens.Black, cellWidth * i, 0, cellWidth * i, pictureBox1.Height);
            }
            label2.Text = mundo.DarPuntuacion.ToString();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (mundo.ObjetosMundo[e.Y * mundo.ObjetosMundo.GetLength(0) / pictureBox1.Height, e.X * mundo.ObjetosMundo.GetLength(1) / pictureBox1.Width] == null)
            { mundo.AgregaObstaculo(e.Y * mundo.ObjetosMundo.GetLength(0) / pictureBox1.Height, e.X * mundo.ObjetosMundo.GetLength(1) / pictureBox1.Width); pictureBox1.Refresh(); }
            else if (mundo.ObjetosMundo[e.Y * mundo.ObjetosMundo.GetLength(0) / pictureBox1.Height, e.X * mundo.ObjetosMundo.GetLength(1) / pictureBox1.Width] is Obstaculos)
            { mundo.EliminaObstaculo(e.Y * mundo.ObjetosMundo.GetLength(0) / pictureBox1.Height, e.X * mundo.ObjetosMundo.GetLength(1) / pictureBox1.Width); pictureBox1.Refresh(); }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            jugar = new Juego(mundo);
            if (jugar.EsValido())
            {
                buttAcept.Visible = false;
                buttJugar.Visible = true;
                buttGuardar.Visible = true;
                numUDvelocid.Visible = true;
                lblveloc.Visible = true;
                lblhuevos.Visible = false;
                numUDhuevos.Visible = false;
                jugar.InsertarSerpiente();
                direccion = jugar.cabezaS.Dir;
                int count = 0;
                for (int i = 0; i < mundo.ObjetosMundo.GetLength(0); i++)
                {
                    for (int j = 0; j < mundo.ObjetosMundo.GetLength(1); j++)
                    { if (mundo.ObjetosMundo[i, j] == null) count++; }
                }
                if (count < (int)numUDhuevos.Value)
                {
                    MessageBox.Show("No es posible jugar en este mundo!!!");
                    mundo = new Mundos((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    pictureBox1.Refresh();
                    lblFilas.Visible = true;
                    lblColum.Visible = true;
                    numericUpDown1.Visible = true;
                    numericUpDown2.Visible = true;
                    numUDhuevos.Visible = false;
                    numUDvelocid.Visible = false;
                    buttDibuj.Visible = true;
                    buttGuardar.Visible = false;
                    buttJugar.Visible = false;
                    buttAcept.Visible = false;
                    lblhuevos.Visible = false;
                    lblveloc.Visible = false;
                    pictureBox1.Enabled = false;
                }
                else
                {
                    jugar.GeneraHuevo((int)numUDhuevos.Value);
                    cambioParanopintarlineas = true;
                    pictureBox1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Este mundo es Inválido");
                mundo = new Mundos((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                pictureBox1.Refresh();
                lblFilas.Visible = true;
                lblColum.Visible = true;
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                numUDhuevos.Visible = false;
                numUDvelocid.Visible = false;
                buttDibuj.Visible = true;
                buttGuardar.Visible = false;
                buttJugar.Visible = false;
                buttAcept.Visible = false;
                lblhuevos.Visible = false;
                lblveloc.Visible = false;
                pictureBox1.Enabled = false;
            }
        }

        private void SnakeAppCrear_KeyDown(object sender, KeyEventArgs e)
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

        private void ButtGuardar_Click(object sender, EventArgs e)
        {
            archivo.ShowDialog();
            string archivo1 = archivo.FileName;
            if (archivo1 == "") return;
            if (archivo1.Contains(".pdf") || archivo1.Contains(".epub") || archivo1.Contains(".mobi") || archivo1.Contains(".html")) return;
            if (!archivo1.Contains(".txt")) archivo1 += ".txt";
            StreamWriter sr = new StreamWriter(archivo1);
            sr.WriteLine(numericUpDown1.Value);
            sr.WriteLine(numericUpDown2.Value);
            for (int i = 0; i < mundo.ObjetosMundo.GetLength(0); i++)
                for (int j = 0; j < mundo.ObjetosMundo.GetLength(1); j++)
                    if (mundo.ObjetosMundo[i, j] is Obstaculos) sr.WriteLine("{0},{1}", i, j);
            sr.WriteLine(numUDhuevos.Value);
            sr.WriteLine(numUDvelocid.Value);
            sr.Close();
        }

        private void ButtJugar_Click(object sender, EventArgs e)
        {
            buttGuardar.Visible = false;
            ActiveControl = null;
            lblveloc.Visible = false;
            numUDvelocid.Visible = false;
            if ((int)numUDvelocid.Value == 1) timer1.Interval = 605;
            if ((int)numUDvelocid.Value == 2) timer1.Interval = 420;
            if ((int)numUDvelocid.Value == 3) timer1.Interval = 135;
            timer1.Start();
            buttJugar.Visible = false;
        }

        private void SnakeAppCrear_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (jugar.Ganas)
            {
                timer1.Stop();
                MessageBox.Show("Felicidades! Usted ha ganado \nPuntuación: " + mundo.DarPuntuacion.ToString());
                cambioParanopintarlineas = false;
                mundo = new Mundos((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                pictureBox1.Refresh();
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                lblFilas.Visible = true;
                lblColum.Visible = true;
                numUDhuevos.Visible = false;
                numUDvelocid.Visible = false;
                buttDibuj.Visible = true;
                buttGuardar.Visible = false;
                buttJugar.Visible = false;
                buttAcept.Visible = false;
                lblhuevos.Visible = false;
                lblveloc.Visible = false;
                pictureBox1.Enabled = false;
                return;
            }
            jugar.Movimiento(direccion);
            pictureBox1.Refresh();
            if (!jugar.PuedesJugar)
            {
                timer1.Stop();
                MessageBox.Show("Uhh! Usted ha perdido \nPuntuación: " + mundo.DarPuntuacion.ToString() + "\nInténtelo de nuevo");
                cambioParanopintarlineas = false;
                mundo = new Mundos((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                pictureBox1.Refresh();
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
                lblFilas.Visible = true;
                lblColum.Visible = true;
                numUDhuevos.Visible = false;
                numUDvelocid.Visible = false;
                buttDibuj.Visible = true;
                buttGuardar.Visible = false;
                buttJugar.Visible = false;
                buttAcept.Visible = false;
                lblhuevos.Visible = false;
                lblveloc.Visible = false;
                pictureBox1.Enabled = false;
                return;
            }
            pictureBox1.Refresh();
        }
    }
}
