using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISU_sistema.View.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaAlunos.Items.Add(txtnome.Text);
        }

        private void ListaAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           




        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {




        }

        private void Load_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");

            foreach (ListViewItem item in ListaAlunos.Items)
            {

                sw.WriteLine(item.Text);






            }

            sw.Close();


        }

        private void AlunoIndex_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Alunos.txt");
            string linha = sr.ReadLine();
            while (linha != null)
            {
                ListaAlunos.Items.Add(linha);
                linha = sr.ReadLine();


                sr.Close();
            }

        }
    }    }
