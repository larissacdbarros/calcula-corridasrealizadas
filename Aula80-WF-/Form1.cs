using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula80_WF_
{
    public partial class Form1 : Form
    {
        Motorista m1 = new Motorista();
        Motorista m2 = new Motorista();
        Motorista m3 = new Motorista();
        Motorista m4 = new Motorista();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            checkBoxViagemM1.Visible = false;
            checkBoxViagemM2.Visible = false;
            checkBoxViagemM3.Visible = false;
            checkBoxViagemM4.Visible = false;
            
            
        }

        private void checkBoxViagemM1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxOnM1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnM1.Checked == true)
            {
                checkBoxViagemM1.Visible = true;
            }
            else
            {
                checkBoxViagemM1.Visible = false;
            }
        }

        private void checkBoxOnM2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnM2.Checked == true)
            {
                checkBoxViagemM2.Visible = true;
            }
            else
            {
                checkBoxViagemM2.Visible = false;
            }
        }

        private void checkBoxOnM3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnM3.Checked == true)
            {
                checkBoxViagemM3.Visible = true;
            }
            else
            {
                checkBoxViagemM3.Visible = false;
            }
        }

        private void checkBoxOnM4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnM4.Checked == true)
            {
                checkBoxViagemM4.Visible = true;
            }
            else
            {
                checkBoxViagemM4.Visible = false;
            }
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            Viagem v1m1 = new Viagem(int.Parse(txtMinM1.Text));
            v1m1.ValorViagem();
            m1.Viajar(v1m1);
            txtMinM1.Clear();
            checkBoxViagemM1.Checked = false;
            m1.ValorTotal += v1m1.Valor; 
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            
            Viagem v2m2 = new Viagem(int.Parse(txtMinM2.Text));
            v2m2.ValorViagem();
            m2.Viajar(v2m2);
            txtMinM2.Clear();
            checkBoxViagemM2.Checked = false;
            m2.ValorTotal += v2m2.Valor;
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            
            Viagem v3m3 = new Viagem(int.Parse(txtMinM3.Text));
            v3m3.ValorViagem();
            m3.Viajar(v3m3);
            txtMinM3.Clear();
            checkBoxViagemM3.Checked = false;
            m3.ValorTotal += v3m3.Valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Viagem v4m4 = new Viagem(int.Parse(txtMinM4.Text));
            v4m4.ValorViagem();
            m4.Viajar(v4m4);
            txtMinM4.Clear();
            checkBoxViagemM4.Checked = false;
            m4.ValorTotal += v4m4.Valor;
        }

        private void btnM4_Click(object sender, EventArgs e)
        {

            RelatorioViagens relV = new RelatorioViagens();
            relV.lblQtdM1.Text = m1.Viagens.Count().ToString();
            relV.lblValorM1.Text = "R$" + m1.ValorTotal.ToString();

            relV.lblQtdM2.Text = m2.Viagens.Count().ToString();
            relV.lblValorM2.Text = "R$" + m2.ValorTotal.ToString();

            relV.lblQtdM3.Text = m3.Viagens.Count().ToString();
            relV.lblValorM3.Text = "R$" + m3.ValorTotal.ToString();

            relV.lblQtdM4.Text = m4.Viagens.Count().ToString();
            relV.lblValorM4.Text = "R$" + m4.ValorTotal.ToString();


            relV.ShowDialog();
        }
    }
}
