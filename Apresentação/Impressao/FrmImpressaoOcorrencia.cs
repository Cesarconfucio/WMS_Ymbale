using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wms.Relatorio;

namespace Wms.Impressao
{
    public partial class FrmImpressaoOcorrencia : Form
    {
        public FrmImpressaoOcorrencia()
        {
            InitializeComponent();
        }

        //Keypress
        private void cmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtmInicial.Focus();
            }
        }

        private void dtmInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtmFinal.Focus();
            }
        }

        private void dtmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAnalisar.Focus();
            }
        }

        //Click
        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            if(cmbTipo.Text.Equals("DEVOLUÇÃO"))
            {
                //Gera o relatório de devolução
                FrmMapaOcorrencia frame = new FrmMapaOcorrencia();
                frame.GerarRelatorio("True", "", dtmInicial.Text, dtmFinal.Text);
            }
            else if (cmbTipo.Text.Equals("REENTREGA"))
            {
                //Gera o relatório de Reentrega
                FrmMapaOcorrencia frame = new FrmMapaOcorrencia();
                frame.GerarRelatorio("", "True", dtmInicial.Text, dtmFinal.Text);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um tipo de relatório!", "Wms - Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha o frame
            Close();
        }

        private void cmbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTipoRel.Text.Equals("COMERCIAL"))
            {
                //Gera o relatório de devolução
                FrmMapaOcorrencia frame = new FrmMapaOcorrencia();
                frame.GerarRelatorio("True", "", dtmInicial.Text, dtmFinal.Text);
            }
            else if (cmbTipoRel.Text.Equals("LOGISTICA"))
            {
                //Gera o relatório de Reentrega
                FrmMapaOcorrencia frame = new FrmMapaOcorrencia();
                frame.GerarRelatorio("", "True", dtmInicial.Text, dtmFinal.Text);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um tipo de relatório!", "Wms - Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
