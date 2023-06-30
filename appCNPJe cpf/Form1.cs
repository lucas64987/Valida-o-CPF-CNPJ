using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace appCNPJe_cpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string documento = TxtCampoEntrada.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            if (Rbtncpf.Checked)
            {
                if (ValidarCPF(documento))
                {
                    MessageBox.Show("CPF válido!", "CPF VALIDADO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("CPF inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Rbtncnpj.Checked)
            {
                if (ValidarCNPJ(documento))
                {
                    MessageBox.Show("CNPJ válido!", "CNPJ VALIDADO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("CNPJ inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool ValidarCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            if (TodosDigitosIguais(cpf))
            {
                return false;
            }

            if (!VerificarDigitoVerificador(cpf, 9, 10))
            {
                return false;
            }

            if (!VerificarDigitoVerificador(cpf, 10, 11))
            {
                return false;
            }

            return true;
        }

        private bool TodosDigitosIguais(string cpf)
        {
            for (int i = 1; i < 11; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    return false;
                }
            }

            return true;
        }

        private bool VerificarDigitoVerificador(string cpf, int multiplicadorInicial, int multiplicadorFinal)
        {
            int soma = 0;

            for (int i = 0; i < multiplicadorInicial; i++)
            {
                soma += (cpf[i] - '0') * (multiplicadorInicial + 1 - i);
            }

            int digitoVerificador = 11 - (soma % 11);

            if (digitoVerificador >= 10)
            {
                digitoVerificador = 0;
            }

            return cpf[multiplicadorInicial] - '0' == digitoVerificador;
        }

        private bool ValidarCNPJ(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", ""); // Remove caracteres especiais

            if (cnpj.Length != 14 || !long.TryParse(cnpj, out _))
                return false;

            int[] multiplicadores1 = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string digitoVerificador = cnpj.Substring(12);

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int primeiroDigito = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(digitoVerificador[0].ToString()) != primeiroDigito)
                return false;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int segundoDigito = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(digitoVerificador[1].ToString()) != segundoDigito)
                return false;

            return true;
        }
        
         
        

        private void BtnCANCELAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
