using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xadriz
{
    public partial class EscolherCor : Form
    {
        String cor1;
        String cor2;
        public EscolherCor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cor1 = cbCor1.Text;
            cor2 = cbCor2.Text;
            Form1 abrir = new Form1(cor1,cor2);
            abrir.Show();
        }

        private void cbCor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbCor1.Text)
            {
                case "Vermelho": pn1.BackColor = Color.Red;
                    pn4.BackColor = Color.Red;
                    break;
                case "Amarelo": pn1.BackColor = Color.Yellow;
                    pn4.BackColor = Color.Yellow;
                    break;
                case "Azul": pn1.BackColor = Color.Blue;
                    pn4.BackColor = Color.Blue;
                    break;
                case "Verde": pn1.BackColor = Color.Green;
                    pn4.BackColor = Color.Green;
                    break;
            }
        }

        private void cbCor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCor2.Text)
            {
                case "Vermelho": pn2.BackColor = Color.Red;
                    pn3.BackColor = Color.Red;
                    break;
                case "Amarelo": pn2.BackColor = Color.Yellow;
                    pn3.BackColor = Color.Yellow;
                    break;
                case "Azul": pn2.BackColor = Color.Blue;
                    pn3.BackColor = Color.Blue;
                    break;
                case "Verde": pn2.BackColor = Color.Green;
                    pn3.BackColor = Color.Green;
                    pn3.BackColor = Color.Green;
                    pn3.BackColor = Color.Green;
                    pn3.BackColor = Color.Green;
                    break;
            }
        }
    }
}
