using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corsi___sperimentazione
{
    public partial class Form1 : Form
    {
        //variabili
        public string[] array;
        public int indice;
        public Form1()
        {
            InitializeComponent();
            //inizializzare qua le variabili
            array = new string[100];
            indice = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PulsanteAggiunta_Click(object sender, EventArgs e)
        {
            Aggiungi(array, ref indice, TextBox1.Text);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void PulsanteStampa_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //funzione di servizio
        public void Aggiungi(string[] array, ref int indice, string nome)
        {
            array[indice] = nome;
            indice++;
        }
       
    }
}
