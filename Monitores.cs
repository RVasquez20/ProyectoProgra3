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
using System.Collections;
namespace ProyectoProgra3
{
    public partial class Monitores : Form
    {

        public Monitores()
        {
            InitializeComponent();
            Mpalabras.Text = "";
            string palabras = "";
            TextReader textReader = new StreamReader(@"Palabras.txt");
            palabras = textReader.ReadToEnd();
            textReader.Close();
            Mpalabras.Text = palabras;
            mfacs.Text = "";
            string Factura = "";
            TextReader textReaderF = new StreamReader(@"Facturas.txt");
            Factura = textReaderF.ReadToEnd();
            textReaderF.Close();
            mfacs.Text = Factura;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            Mpalabras.Text = "";
            string palabras = "";
            TextReader textReader = new StreamReader(@"Palabras.txt");
            palabras = textReader.ReadToEnd();
            textReader.Close();
            Mpalabras.Text = palabras;
        }

        private void fileSystemWatcher2_Changed(object sender, FileSystemEventArgs e)
        {
            mfacs.Text = "";
            string Factura = "";
            TextReader textReader = new StreamReader(@"Facturas.txt");
            Factura = textReader.ReadToEnd();
            textReader.Close();
            mfacs.Text = Factura;
        }
    }
}
