using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.NetworkInformation;
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
            cnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

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
        String gerarcpf()
        {
            Random rnd = new Random();

            int n1 = rnd.Next(0, 10);
            int n2 = rnd.Next(0, 10);
            int n3 = rnd.Next(0, 10);
            int n4 = rnd.Next(0, 10);
            int n5 = rnd.Next(0, 10);
            int n6 = rnd.Next(0, 10);
            int n7 = rnd.Next(0, 10);
            int n8 = rnd.Next(0, 10);
            int n9 = rnd.Next(0, 10);

            int soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

            int digitoVerificador1 = soma1 % 11;

            if (digitoVerificador1 < 2)
            {
                digitoVerificador1 = 0;
            }

            else
            {
                digitoVerificador1 = 11 - digitoVerificador1;
            }

            int soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

            int digitoverificador2 = soma2 % 11;

            if (digitoverificador2 < 2)
            {
                digitoverificador2 = 0;
            }
            else
            {
                digitoverificador2 = 11 - digitoverificador2;
            }

            return n1.ToString() + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + digitoVerificador1 + digitoverificador2;
        }
        private void Btncpf_Click(object sender, EventArgs e)
        {
            TxtCampoEntrada.Text = gerarcpf();
        }
        string gerarCNPJ()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(0, 10);
            int n2 = rnd.Next(0, 10);
            int n3 = rnd.Next(0, 10);
            int n4 = rnd.Next(0, 10);
            int n5 = rnd.Next(0, 10);
            int n6 = rnd.Next(0, 10);
            int n7 = rnd.Next(0, 10);
            int n8 = rnd.Next(0, 10);
            int n9 = 0;
            int n10 = 0;
            int n11 = 0;
            int n12 = 1;

            int soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

            int dv1 = soma1 % 11;

            if (dv1 < 2)
            {
                dv1 = 0;

            }
            else
            {
                dv1 = 11 - dv1;
            }

            int soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + dv1 * 2;

            int dv2= soma2 % 11;

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }
            return n1.ToString() + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12+ dv1 + dv2;

        }

        private void Btncnpj_Click(object sender, EventArgs e)
        {
            TxtCampoEntrada.Text = gerarCNPJ();
        }
    }
}


