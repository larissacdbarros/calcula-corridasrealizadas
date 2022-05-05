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
    public partial class RelatorioViagens : Form
    {
        public RelatorioViagens()
        {
            InitializeComponent();
        }

        private void RelatorioViagens_Load(object sender, EventArgs e)
        {

           
        }

        private void btnM1_Click(object sender, EventArgs e)
        {

            TelaMotorista tl = new TelaMotorista();
           
            tl.txtMotorista.Text = "Motorista 1";
            tl.lblTotalViagensRelIndivi.Text = lblQtdM1.Text;
            tl.lblValorTotalRelIndivi.Text = lblValorM1.Text;
            tl.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaMotorista tl = new TelaMotorista();

            tl.txtMotorista.Text = "Motorista 2";
            tl.lblTotalViagensRelIndivi.Text = lblQtdM2.Text;
            tl.lblValorTotalRelIndivi.Text = lblValorM2.Text;
            tl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaMotorista tl = new TelaMotorista();

            tl.txtMotorista.Text = "Motorista 3";
            tl.lblTotalViagensRelIndivi.Text = lblQtdM3.Text;
            tl.lblValorTotalRelIndivi.Text = lblValorM3.Text;
            tl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaMotorista tl = new TelaMotorista();

            tl.txtMotorista.Text = "Motorista 4";
            tl.lblTotalViagensRelIndivi.Text = lblQtdM4.Text;
            tl.lblValorTotalRelIndivi.Text = lblValorM4.Text;
            tl.ShowDialog();
        }
    }
}
