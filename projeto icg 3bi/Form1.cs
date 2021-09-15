/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 30/09/2020
 * Autores do Projeto: Yan massahiro ueno
 * Turma: 3f
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * Nome_prog.cs
 * ******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace projeto_icg_3bi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap pato;
        Bitmap barco;
        Bitmap fotopronta;
        private void junta_imagem()
        {
            Bitmap foto = pato;
            Bitmap cenario = barco;
  
            int larg = pato.Width -1;
            int alt = pato.Width - 1;
            for (int l = 1; l <= larg-1; l++)
            {
                for (int a = 1; a <= alt-1; a++)
                {
                    int r = pato.GetPixel(l,a).R;
                    int g = pato.GetPixel(l, a).G;
                    int b = pato.GetPixel(l, a).B;
                    if (r== 127 && g == 127 && b == 127)
                    {
                        //
                    }
                    else
                        //MessageBox.Show("asdasd");
                        cenario.SetPixel(l + 260,a ,Color.FromArgb(r,g,b));
                    }
                }

            pictureA.Image = cenario;
            fotopronta = new Bitmap(cenario);
            fotopronta.Save("fotoColorida.bmp");
        }

        Bitmap PB;
        private void convertegrayscale()
        {
            int larg = fotopronta.Width;
            int alt = fotopronta.Height;
            PB = new Bitmap(fotopronta);
            for (int l = 0; l <= larg - 1; l++)
            {
                for (int a = 0; a <= alt - 1; a++)
                {
                    int r = fotopronta.GetPixel(l, a).R;
                    int g = fotopronta.GetPixel(l, a).G;
                    int b = fotopronta.GetPixel(l, a).B;
                    int cinza = (int)((r * 0.30) + (g * 0.59) + (b * 0.11));
                    PB.SetPixel(l, a, Color.FromArgb(cinza, cinza, cinza));

                }
            }
            pictureB.Image = PB;
            PB.Save("fotoPretoBranco.bmp");
        }
        Bitmap binario;
        private void converterBinario()
        {
            int larg = PB.Width;
            int alt = PB.Height;
            binario = new Bitmap(PB);
            for (int l = 1; l <= larg - 1; l++)
            {
                for (int a = 1; a <= alt - 1; a++)
                {
                    int r = binario.GetPixel(l, a).R;
                    int g = binario.GetPixel(l, a).G;
                    int b = binario.GetPixel(l, a).B;
                    int cinza = (int)((r * 0.30) + (g * 0.59) + (b * 0.11));
                    if (cinza < 127)
                    {
                        binario.SetPixel(l, a, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        binario.SetPixel(l, a, Color.FromArgb(255, 255, 255));
                    }

                }
            }
            pictureC.Image = binario;
            binario.Save("Binario.bmp");
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            junta_imagem();
            convertegrayscale();
            converterBinario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pato = new Bitmap(pictureB.Image);
            barco = new Bitmap(pictureA.Image);
        }  
             
    }
}
