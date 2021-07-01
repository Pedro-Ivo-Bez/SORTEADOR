using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORTEADOR_ONLINE_GRATIS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BItens_Click(object sender, EventArgs e)
        {

        }

        private void AddItens_TextChanged(object sender, EventArgs e)
        {

        }

        private void BParticipantes_Click(object sender, EventArgs e)
        {

            string a = AddParticipante.Text;

            if (AddParticipante.Text == "" || AddParticipante.Text.StartsWith(" "))
            {
                MessageBox.Show("Valores Inválidos!!");
                AddParticipante.Text = "";
            }
            else
            {

                ListViewItem lst = new ListViewItem(a);
                ListParticipantes.Items.Add(lst).ToString();
                AddParticipante.Text = "";
                DataBase.ListaParticipantes.Add(new Participante(a));
            }
        }

        private void BItens_Click_1(object sender, EventArgs e)
        {
            string b = AddItens.Text;

            if (AddItens.Text == "" || AddItens.Text.StartsWith(" "))
            {
                MessageBox.Show("Valores Inválidos!!");
                AddItens.Text = "";
            }
            else
            {

                ListViewItem lst1 = new ListViewItem(b);
                ListItens.Items.Add(lst1);
                AddItens.Text = "";
                DataBase.ListaItens.Add(new Item(b));
            }
        }

        private void BLimpar_Click(object sender, EventArgs e)
        {
            ListItens.Items.Clear();
            ListParticipantes.Items.Clear();
            ResultP.Clear();
            ResultI.Clear();
            DataBase.ListaParticipantes.Clear();
        }

        private void BSortear_Click(object sender, EventArgs e)
        {
            if (DataBase.ListaParticipantes.Count == 0)
            {
                MessageBox.Show("Não existem participantes válidos!");
                return;
            }
            if (DataBase.ListaItens.Count == 0)
            {
                MessageBox.Show("Não existem itens válidos!");
                return;
            }

            Random rnd = new Random();
            int numerorandom = rnd.Next(0, ListParticipantes.Items.Count);

            Participante p = DataBase.ListaParticipantes[numerorandom];
            DataBase.ListaParticipantes.RemoveAt(numerorandom);

            ResultP.Text = p.Nome;
            ListParticipantes.Items.RemoveAt(numerorandom);
            //
            Random rnd2 = new Random();
            int numerorandom2 = rnd2.Next(0, ListItens.Items.Count);

            Item w = DataBase.ListaItens[numerorandom2];
            DataBase.ListaItens.RemoveAt(numerorandom2);

            ResultI.Text = w.Nome;
            ListItens.Items.RemoveAt(numerorandom2);
        }
    }
}