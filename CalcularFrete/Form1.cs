using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularFrete_Click(object sender, EventArgs e)
        {
            if (validarCampos() != true)
                return;



            try
            {
                // convertendo texto em decimal
                var freteMinimo = Convert.ToDecimal(txtFreteMinimo.Text);
                // convertendo objeto em string
                var uf = (string)cbxUf.SelectedItem;

                CalcularFrete(freteMinimo, uf);
            }
            // capturar o erro se ocorrer
            catch (Exception ex)
            {
                // log do erro
                Console.WriteLine(ex.Message);

                // limpar campo com uma string vazia
                txtFreteMinimo.Text = String.Empty;

                // coloca o foco no teclado no txt
                txtFreteMinimo.Focus();

                // mensagem para o usuario
                MessageBox.Show("Informe o valor do frete",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        void CalcularFrete(decimal freteMinimo, string uf)
        {
            // variavel do tipo decimal
            var adicional = 5.0M;
            var freteFinal = 0.0M;

            // se uf == RS
            if (uf.Equals("RS"))
            {
                freteFinal = freteMinimo + 0.5M;

            }
            else if (uf.Equals("SC"))
            {
                freteFinal = freteMinimo + 1.0M;
            }
            else if (uf.Equals("PR"))
            {
                freteFinal = freteMinimo + 2.0M;
            }
            else if (uf.Equals("SP"))
            {
                freteFinal = freteMinimo + 3.0M;
            }
            else
            {
                freteFinal = freteMinimo + adicional;
            }

            txtTotalFrete.Text = freteFinal.ToString("F2");
        }
        bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtFreteMinimo.Text))
            {
                txtFreteMinimo.Focus();
                ExibirMensagem("Informe frete mínimo.");
                return false;
            }

            // verifica se o texto do cbx está vazio seta o foco e exibe msg
            if (string.IsNullOrEmpty(cbxUf.Text))
            {
                cbxUf.Focus();
                ExibirMensagem("Informe a UF!");
                return false;
            }

            return true;
        }

        private void ExibirMensagem(string msg)
        {
            MessageBox.Show(msg, 
                "", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }
    }
}
