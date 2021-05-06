using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace ProyectoProgra3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Generador();
        }

        private void palabrasYFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Monitores"] as Monitores) == null)
            {
                Monitores monitores = new Monitores();
                monitores.Show();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto Programacion 3 \n Jose Rodrigo Figueroa Guerra\n1290-19-14365");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue<String> direcciones = new Queue<String>();
            Queue<Queue<Bitmap>> Listado = new Queue<Queue<Bitmap>>();
            if ((Application.OpenForms["Captcha"] as Captcha) == null)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string item in openFileDialog1.FileNames)
                    {
                        direcciones.Enqueue(item);
                    }
                    foreach (String item in direcciones)
                    {
                        Listado.Enqueue(Recortes(item));
                    }

                    Captcha captcha = new Captcha(Listado);
                    captcha.Show();
                }
            }
        }
        public Bitmap Recorte(Bitmap imagen, Rectangle tamanioanchoalto)
        {
            Bitmap bitmap = new Bitmap(tamanioanchoalto.Width, tamanioanchoalto.Height);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.DrawImage(imagen, 0, 0, tamanioanchoalto, GraphicsUnit.Pixel);
            return bitmap;
        }
        public Queue<Bitmap> Recortes(string path)
        {

            Queue<Bitmap> ListadeRecortes = new Queue<Bitmap>();
            int X = 0, Y = 0, ancho = 200, altura = 100;
            Bitmap bitmap = new Bitmap(@path);


            for (int i = 0; i < (bitmap.Height / 100); i++)
            {
                X = 0;
                for (int j = 0; j < (bitmap.Width / 200); j++)
                {
                    Rectangle Cuadro = new Rectangle(X, Y, ancho, altura);

                    Bitmap pedazo = Recorte(bitmap, Cuadro);
                    ListadeRecortes.Enqueue(pedazo);

                    X = 200;
                }
                Y += 100;
            }
            return ListadeRecortes;
        }
        public void Generador()
        {
            if (!File.Exists(@"Palabras.txt"))
            {

                TextWriter text = new StreamWriter(@"Palabras.txt");
                text.WriteLine("0");
                text.WriteLine("Tierra");
                text.WriteLine("1");
                text.WriteLine("Mar");
                text.WriteLine("2");
                text.WriteLine("Agua");
                text.Close();
            }
            if (!File.Exists(@"Facturas.txt"))
            {
                TextWriter text = new StreamWriter(@"Facturas.txt");
                text.Close();
            }
        }
    }
}
