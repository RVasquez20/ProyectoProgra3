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
    public partial class Captcha : Form
    {
        string Inicio="",Steps="",PalabraConfirmadaUS="";
        int iteraciones = 3, Recotes = 0,iteracionesconfirmadas=1;
        Hashtable PC = new Hashtable();
        Queue<Bitmap> ListadoDeRecortes = new Queue<Bitmap>();
        Queue<Queue<Bitmap>> Listado = new Queue<Queue<Bitmap>>();
        public Captcha(Queue<Queue<Bitmap>>ListadoRecortes)
        {
            InitializeComponent();
            Listado = ListadoRecortes;
            ListadoDeRecortes = Listado.Dequeue();
            img_NoConfirmada.Image = ListadoDeRecortes.Dequeue();
            ChargeData();
            txt_conf.Text = PC["0"].ToString();


        }
        private void Verificar_Click(object sender, EventArgs e)
        {
            if(txt_Confirmada.Text.Equals("")|| txt_noConfirmada.Text.Equals(""))
            {
                MessageBox.Show("Llene los datos");
            }
            else
            {
                if (iteracionesconfirmadas > PC.Count)
                {
                    iteracionesconfirmadas = 1;
                }
              
                 if (iteraciones == 3)
                {
                    PalabraConfirmadaUS = "";
                    Inicio = "";
                    Inicio = txt_noConfirmada.Text;
                    PalabraConfirmadaUS = txt_conf.Text;
                    if (PalabraConfirmadaUS.Equals(txt_Confirmada.Text))
                    {
                        iteraciones--;
                        txt_noConfirmada.Focus();
                        txt_noConfirmada.Text = "";
                        txt_Confirmada.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error No Coinciden Inicie nuevamente");
                        iteraciones = 3;
                        txt_noConfirmada.Focus();
                    }
                }
                else
                if (iteraciones>0 && iteraciones<3)
                {
                    PalabraConfirmadaUS = "";
                    Steps = "";
                    Steps = txt_noConfirmada.Text;
                    PalabraConfirmadaUS = txt_Confirmada.Text;
                    if (Inicio.Equals(Steps)&&PalabraConfirmadaUS.Equals(txt_conf.Text))
                    {
                        txt_noConfirmada.Focus();
                        iteraciones--; txt_noConfirmada.Text = "";
                        txt_Confirmada.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error No Coinciden Inicie nuevamente");
                        iteraciones = 3;
                        txt_noConfirmada.Focus(); txt_noConfirmada.Text = "";
                        txt_Confirmada.Text = "";
                    }
                }
                if (iteraciones == 0)
                {
                    PalabraConfirmadaUS = "";
                    txt_noConfirmada.Text = "";
                    txt_Confirmada.Text = "";
                    txt_noConfirmada.Focus();
                    MessageBox.Show("Palabra Confirmada");
                    string k = "";
                    k = Convert.ToString(NuevaK());
                    PC.Add(k, Inicio);
                    SaveWord(k, Inicio);
                    
                    txt_conf.Text = PC[iteracionesconfirmadas.ToString()].ToString();
                    Recotes++;
                    SaveInvove(Recotes, Inicio);
                    iteracionesconfirmadas++;
                    if (ListadoDeRecortes.Count !=0)
                    {
                        img_NoConfirmada.Image = ListadoDeRecortes.Dequeue();
                        this.Invoke(new Action(() => { img_NoConfirmada.Refresh(); }));
                        iteraciones = 3;
                    }
                    else
                   
                        if (ListadoDeRecortes.Count==0&&Listado.Count != 0)
                        {
                            ListadoDeRecortes.Clear();
                            ListadoDeRecortes = Listado.Dequeue();
                            iteracionesconfirmadas = 1;
                            img_NoConfirmada.Image = ListadoDeRecortes.Dequeue();
                            txt_conf.Text = PC["0"].ToString();
                            this.Invoke(new Action(() => { img_NoConfirmada.Refresh(); }));
                            iteraciones = 3;
                        }
                        else
                        {
                            this.Close();
                        }
                    }

                

            }
        }

        private void SaveInvove(int recortes, string inicio)
        {
            TextWriter sw = new StreamWriter(@"Facturas.txt", true);
            if (recortes == 1)
            {
                sw.WriteLine("Nit: " + inicio);
            }
            else if (recortes == 2)
            {
                sw.WriteLine("Fecha: " + inicio);
            }
            else if (recortes % 2 == 0)
            {
                sw.WriteLine("Cantidad: " + inicio);
            }
            else
            {
                sw.WriteLine("Producto: " + inicio);
            }
            sw.Close();
        }

        private int NuevaK()
        {
            return PC.Count ;
        }

        private void ChargeData()
        {
            string p = "", k = "";

            TextReader text = new  StreamReader(@"Palabras.txt");
            k = text.ReadLine();
            p = text.ReadLine();
            while (k!=null)
            {
                PC.Add(k, p);
                k = text.ReadLine();
                p = text.ReadLine();

            }
            text.Close();
        }
        private void SaveWord(string k,string p)
        {
            TextWriter text = new StreamWriter(@"Palabras.txt",true);
            text.WriteLine(k);
            text.WriteLine(p);
            text.Close();
        }

    }
}
